using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WinLIRC.NET;

namespace WinLIRC.Configuration
{
    /// <summary>
    /// WinLIRC.NET configuration source
    /// </summary>
    public class ConfigurationSource
    {
        /// <summary>
        /// Reads WinLIRC configuration file
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public List<irconfig> ReadConfig(FileInfo f)
        {
            List<irconfig> result = new List<irconfig>();

            try
            {
                irconfig config = null;

                List<code> codes = null;

                bool parsingCodes = false;

                using (StreamReader reader = new StreamReader(f.FullName))
                {
                    while (!reader.EndOfStream)
                    {
                        string i = reader.ReadLine();
                        i = i.Trim();
                        i = i.ToLower();

                        if (i.StartsWith("#"))
                            continue;

                        if (i.Equals("begin remote"))
                            config = new irconfig();

                        if (i.Equals("end remote"))
                        {
                            if (config != null)
                                result.Add(config);
                        }

                        if (parsingCodes)
                        {
                            string[] args = i.Split(' ');

                            if (args.Length > 1)
                            {
                                if (codes != null)
                                {
                                    code c = new code();
                                    c.name = args[0];
                                    c.value = args[args.Length - 1];
                                    c.key = codeKey.UNKNOWN;

                                    codes.Add(c);
                                }
                            }
                        }

                        if (i.Equals("begin codes"))
                        {
                            parsingCodes = true;

                            if (config != null)
                                codes = new List<code>();
                        }

                        if (i.Equals("end codes"))
                        {
                            parsingCodes = false;

                            if (config != null & codes != null)
                                config.remote_codes = codes.ToArray();
                        }

                        if (!parsingCodes)
                        {
                            #region Parsing Fields

                            if (i.StartsWith("name"))
                            {
                                if (config != null)
                                    config.name = Tokenize(i, "name");
                            }

                            if (i.StartsWith("bits"))
                            {
                                if (config != null)
                                    config.bits = Tokenize(i, "bits");
                            }

                            if (i.StartsWith("flags"))
                            {
                                if (config != null)
                                    config.flags = Tokenize(i, "flags");
                            }

                            if (i.StartsWith("eps"))
                            {
                                if (config != null)
                                    config.eps = Tokenize(i, "eps");
                            }

                            if (i.StartsWith("aeps"))
                            {
                                if (config != null)
                                    config.aeps = Tokenize(i, "aeps");
                            }

                            if (i.StartsWith("header"))
                            {
                                if (config != null)
                                    config.header = Tokenize(i, "header");
                            }

                            if (i.StartsWith("three"))
                            {
                                if (config != null)
                                    config.three = Tokenize(i, "three");
                            }

                            if (i.StartsWith("two"))
                            {
                                if (config != null)
                                    config.two = Tokenize(i, "two");
                            }

                            if (i.StartsWith("one"))
                            {
                                if (config != null)
                                    config.one = Tokenize(i, "one");
                            }

                            if (i.StartsWith("zero"))
                            {
                                if (config != null)
                                    config.zero = Tokenize(i, "zero");
                            }

                            if (i.StartsWith("ptrail"))
                            {
                                if (config != null)
                                    config.ptrail = Tokenize(i, "ptrail");
                            }

                            if (i.StartsWith("plead"))
                            {
                                if (config != null)
                                    config.plead = Tokenize(i, "plead");
                            }

                            if (i.StartsWith("foot"))
                            {
                                if (config != null)
                                    config.foot = Tokenize(i, "foot");
                            }

                            if (i.StartsWith("repeat"))
                            {
                                if (config != null)
                                    config.repeat = Tokenize(i, "repeat");
                            }

                            if (i.StartsWith("pre_data_bits"))
                            {
                                if (config != null)
                                    config.pre_data_bits = Tokenize(i, "pre_data_bits");
                            }

                            if (i.StartsWith("pre_data"))
                            {
                                if (config != null)
                                    config.pre_data = Tokenize(i, "pre_data");
                            }

                            if (i.StartsWith("post_data_bits"))
                            {
                                if (config != null)
                                    config.post_data_bits = Tokenize(i, "post_data_bits");
                            }

                            if (i.StartsWith("post_data"))
                            {
                                if (config != null)
                                    config.post_data = Tokenize(i, "post_data");
                            }

                            if (i.StartsWith("pre"))
                            {
                                if (config != null)
                                    config.pre = Tokenize(i, "pre");
                            }

                            if (i.StartsWith("post"))
                            {
                                if (config != null)
                                    config.post = Tokenize(i, "post");
                            }

                            if (i.StartsWith("gap"))
                            {
                                if (config != null)
                                    config.gap = Tokenize(i, "gap");
                            }

                            if (i.StartsWith("repeat_gap"))
                            {
                                if (config != null)
                                    config.repeat_gap = Tokenize(i, "repeat_gap");
                            }

                            if (i.StartsWith("min_repeat"))
                            {
                                if (config != null)
                                    config.min_repeat = Tokenize(i, "min_repeat");
                            }

                            if (i.StartsWith("toggle_bit"))
                            {
                                if (config != null)
                                    config.toggle_bit = Tokenize(i, "toggle_bit");
                            }

                            if (i.StartsWith("frequency"))
                            {
                                if (config != null)
                                    config.frequency = Tokenize(i, "frequency");
                            }

                            if (i.StartsWith("duty_cycle"))
                            {
                                if (config != null)
                                    config.duty_cycle = Tokenize(i, "duty_cycle");
                            }

                            if (i.StartsWith("transmitter"))
                            {
                                if (config != null)
                                    config.transmitter = Tokenize(i, "transmitter");
                            }

                            #endregion
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error in reading WinLIRC remote confg", e);
            }

            return result;
        }

        /// <summary>
        /// Reads WinLIRC.NET configuration file
        /// </summary>
        /// <param name="f"></param>
        /// <returns>Returns list of WinLIRC.NET config</returns>
        public List<irconfig> ReadXml(FileInfo f)
        {
            List<irconfig> result = new List<irconfig>();

            try
            {
                result = Serializer<List<irconfig>>.Current.DeserializeFromFile(f);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error in reading WinLIRC.NET remote XML", e);
            }

            return result;
        }

        /// <summary>
        /// Writes WinLIRC.NET configuration file
        /// </summary>
        /// <param name="f">WinLIRC.NET configuration file</param>
        /// <param name="c">WinLIRC.NET configuration</param>
        public void Write(FileInfo f, List<irconfig> c)
        {
            try
            {
                Serializer<List<irconfig>>.Current.SerializeToFile(c, f);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error in writing WinLIRC.NET remote XML", e);
            }
        }

        /// <summary>
        /// Tokenizes WinLIRC configuration
        /// </summary>
        /// <param name="data">WinLIRC remote data</param>
        /// <param name="token">WinLIRC remote token</param>
        /// <returns></returns>
        private string Tokenize(string data, string token)
        {
            string result = string.Empty;

            try
            {
                if (data.StartsWith(token))
                {
                    string[] args = data.Split(' ');

                    StringBuilder sb = new StringBuilder();

                    foreach (string s in args)
                    {
                        if (!string.IsNullOrEmpty(s) && !s.Equals(token))
                            sb.AppendFormat("{0} ", s);
                    }

                    sb = sb.Remove(sb.Length - 1, 1);

                    result = sb.ToString();
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error in tokenizing WinLIRC.NET remote XML", e);
            }

            return result;
        }
    }
}