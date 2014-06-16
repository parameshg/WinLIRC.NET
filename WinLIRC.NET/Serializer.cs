using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace WinLIRC.NET
{
    /// <summary>
    /// Helper class to serialize/deserialize objects of type T to/from string/file in XML format
    /// </summary>
    /// <typeparam name="T">Object to serialize/deserialize</typeparam>
    public class Serializer<T>
    {
        /// <summary>
        /// Creates a new instance of Serializer
        /// </summary>
        public static Serializer<T> Current { get { return new Serializer<T>(); } }

        /// <summary>
        /// Initializes empty Serializer and restricts to be invoked using the default instance
        /// </summary>
        private Serializer() { }

        /// <summary>
        /// Serializes object T to XML formatted string
        /// </summary>
        /// <param name="o">Object to be serialized</param>
        /// <returns>Serialized XML formatted string</returns>
        public string Serialize(T o)
        {
            string result = string.Empty;

            if (o is Exception)
            {
                BinaryFormatter bin = new BinaryFormatter();

                using (MemoryStream stream = new MemoryStream())
                {
                    bin.Serialize(stream, o);

                    result = Convert.ToBase64String(stream.ToArray());
                }
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (MemoryStream stream = new MemoryStream())
                {
                    if (stream.CanWrite)
                    {
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            serializer.Serialize(writer.BaseStream, o);

                            if (stream.CanSeek)
                                stream.Position = 0;

                            if (stream.CanRead)
                            {
                                using (StreamReader reader = new StreamReader(stream))
                                    result = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Serializes object T to XML file
        /// </summary>
        /// <param name="o">Object to be serialized</param>
        /// <param name="file">File to store XML formatted serialized output</param>
        public void SerializeToFile(T o, FileInfo file)
        {
            SerializeToFile(o, file.FullName);
        }

        /// <summary>
        /// Serializes object T to XML file
        /// </summary>
        /// <param name="o">Object to be serialized</param>
        /// <param name="filename">Filename of the file to store XML formatted serialized output</param>
        public void SerializeToFile(T o, string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.AutoFlush = true;
                writer.Write(Serialize(o));
                writer.Flush();
            }
        }

        /// <summary>
        /// Deserializes XML formatted string to  object T
        /// </summary>
        /// <param name="s">XML formatted string to be deserialized</param>
        /// <param name="e">Encoding of the serialized XML formatted string</param>
        /// <returns>Deserialized object T</returns>
        public T Deserialize(string s, Encoding e)
        {
            T result = default(T);

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (MemoryStream stream = new MemoryStream(e.GetBytes(s)))
                result = (T)serializer.Deserialize(stream);

            return result;
        }

        /// <summary>
        /// Deserializes XML formatted string to  object T
        /// </summary>
        /// <param name="s">XML formatted string to be deserialized</param>
        /// <returns>Deserialized object T</returns>
        public T Deserialize(string s)
        {
            T result = default(T);

            if (typeof(T) == typeof(Exception))
            {
                BinaryFormatter bin = new BinaryFormatter();

                using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(s)))
                    result = (T)bin.Deserialize(stream);
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (MemoryStream stream = new MemoryStream(Encoding.ASCII.GetBytes(s)))
                    result = (T)serializer.Deserialize(stream);
            }

            return result;
        }

        /// <summary>
        /// Deserializes XML formatted bytes to  object T
        /// </summary>
        /// <param name="data">XML formatted bytes to be deserialized</param>
        /// <returns>Deserialized object T</returns>
        public T Deserialize(byte[] data)
        {
            T result = default(T);

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (MemoryStream stream = new MemoryStream(data))
                result = (T)serializer.Deserialize(stream);

            return result;
        }

        /// <summary>
        /// Deserializes XML formatted data from file to object T
        /// </summary>
        /// <param name="file">File containing XML formatted serialized data</param>
        /// <returns>Deserialized object T</returns>
        public T DeserializeFromFile(FileInfo file)
        {
            return DeserializeFromFile(file.FullName);
        }

        /// <summary>
        /// Deserializes XML formatted data from file to object T
        /// </summary>
        /// <param name="filename">Filename of the file containing XML formatted serialized data</param>
        /// <returns>Deserialized object T</returns>
        public T DeserializeFromFile(string filename)
        {
            T result = default(T);

            if (File.Exists(filename))
            {
                string data = string.Empty;

                using (StreamReader reader = new StreamReader(filename))
                    data = reader.ReadToEnd();

                if (!string.IsNullOrEmpty(data))
                    result = (T)Deserialize(data);
            }

            return result;
        }
    }
}