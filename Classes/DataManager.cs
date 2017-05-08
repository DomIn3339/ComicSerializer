using ComicVineLibrary.Models;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace ComicSerializer_Test
{
    public static class DataManager
    {
        public static void createFolders(string path)
        {
            Directory.CreateDirectory(path);
        }

        public static string checkVolumeInfoFileExist(string libPath, string volume_name)
        {
            //return File.Exists(libPath + "\\" +"*\\" + volume_name + "\\volume_info.xml");
            string[] dirs = Directory.GetDirectories(libPath);
            foreach (string dir in dirs)
            {
                if (File.Exists(dir + "\\" + volume_name + "\\volume_info.xml"))
                    return dir;
            }
            return null;
        }

        public static string checkIssueInfoFileExist(string libPath, string volume_name, int issue_number)
        {
            //return File.Exists(libPath + "\\*\\" + "\\" + volume_name + "\\" + issue_number + "\\issue_info.xml");
            string[] dirs = Directory.GetDirectories(libPath);
            foreach (string dir in dirs)
            {
                if (File.Exists(dir + "\\" + volume_name + "\\" + issue_number + "\\issue_info.xml"))
                    return dir;
            }
            return null;
        }

        #region Serialization
        public static void Serialize<T>(T obj, string path, string fileName)
        {
            createFolders(path);
            using (FileStream fs = new FileStream(path + "\\" + fileName, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                formatter.Serialize(fs, obj);
            }
        }

        public static void createVolumeInfoFile(string path, ComicVineVolume vol)
        {
            Serialize(vol, path + "\\" + vol.publisher.publisher_name + "\\" + vol.name, "volume_info.xml");
        }

        public static void createIssueInfoFile(string path, ComicVineVolume vol, ComicVineIssue issue)
        {
            Serialize(issue, path + "\\" + vol.publisher.publisher_name + "\\" + vol.name + "\\" + issue.issue_number, "issue_info.xml");
        }

        public static void createFileInfoFile(string path, ComicVineVolume vol, ComicVineIssue issue, FileInfo info)
        {
            Serialize(info, path + "\\" + vol.publisher.publisher_name + "\\" + vol.name + "\\" + issue.issue_number + "\\" + info.language, info.md5hash + ".xml");

        }
        #endregion

        #region Deserialization
        public static T Deserialize<T>(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                return (T)formatter.Deserialize(fs);
            }
        }

        public static ComicVineVolume getVolumeInfoFromFile(string path, string volume_name)
        {
            return Deserialize<ComicVineVolume>(path + "\\" + volume_name + "\\volume_info.xml");

        }

        public static ComicVineIssue getIssueInfoFromFile(string libPath, string volume_name, int issue_number)
        {
            return Deserialize<ComicVineIssue>(libPath + "\\" + volume_name + "\\" + issue_number + "\\issue_info.xml");
        }
        #endregion

        public static string checkMD5(string path)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }

        //regular expressions
        static Regex Series = new Regex("^(\\d+)?(([&\\w\\s'-])(?!v\\d|(?<=[ #])(\\d(?!\\d*\\s[#\\d]))+(?=(\\W|$))(?!\\))))*", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline);
        static Regex Numbers = new Regex("(?<=[ #]|c|ch)(\\d(?!\\d*\\s[#\\d]))+(?=(\\W|$))(?!\\))", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline);


        public static string getVolumeNameFromFileName(string path)
        {
            string name = "";
            try
            {
                string input = Path.GetFileNameWithoutExtension(path).Replace('.', ' ').Replace('_', ' ');
                name = Series.Match(input).Value;
                if (string.IsNullOrEmpty(name) || char.IsDigit(name[0]) && string.IsNullOrEmpty(Numbers.Match(input).Value))
                {
                    input = Path.GetFileName(Path.GetDirectoryName(path)) + " " + input;
                    name = Series.Match(input).Value;
                }
                if (string.IsNullOrEmpty(name))
                    name = input;
                name = name.Trim();
            }
            catch { }

            return name;
        }

        public static int getIssueNumberFromFileName(string path)
        {
            int number = -1;
            try
            {
                number = Convert.ToInt32(Numbers.Match(Path.GetFileNameWithoutExtension(path).Replace('.', ' ').Replace('_', ' ')).Value);
            }
            catch { }
            return number;
        }
    }
}