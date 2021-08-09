using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TorreJsonReader.VO;
using System.Web.Script.Serialization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TorreJsonReader.BL
{
    static class RequestManager
    {
        private const String urlSearchJobs = @"https://search.torre.co/opportunities/_search/?offset={0}&size={1}&aggregate={2}";
        private const String urlSearchUsers = @"https://search.torre.co/people/_search?offset={0}&size={1}&aggregate={2}";
        private const String urlSearchJob = @" https://torre.co/api/opportunities/";
        private const String urlSearchUser = @"https://torre.bio/api/bios/";
        private const String JsonFileUser = @"..\..\Content\user.json";
        private const String JsonFileJob = @"..\..\Content\job.json";
        private const String JsonFileSearchJobs = @"..\..\Content\searchjobs.json";
        private const String JsonFileSearchUsers = @"..\..\Content\searchusers.json";

        public static Object LoadAllJobs()
        {
            var httpWebRequest = CreatePostHttpJsonRequest(String.Format(urlSearchJobs, 0, 1, true));
            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    string jsonReq = "{\"offset\":\"0\"," +
            //                  "\"size\":\"100\"," +
            //                  "\"aggregate\":\"true\"}";

            //    streamWriter.Write(jsonReq);
            //}
            var writeStatus = WriteRequestResponse(httpWebRequest, JsonFileSearchJobs);
            return LoadJsonFile(JsonFileSearchJobs,1);
        }

        public static Object LoadAllUsers()
        {
            var httpWebRequest = CreatePostHttpJsonRequest(String.Format(urlSearchUsers, 0, 1, true));

            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    string jsonUsers = "{\"offset\":\"0\"," +
            //                        "\"size\":\"100\"," +
            //                  "\"aggregate\":\"true\"}";

            //    streamWriter.Write(jsonUsers);
            //}
            var writeStatus = WriteRequestResponse(httpWebRequest, JsonFileSearchUsers);
            return LoadJsonFile(JsonFileSearchUsers, 2);
        }

        public static Object SearchJobsByKeyword(string keyword,int offset,int size,Boolean aggregate)
        {
            //var url = "https://search.torre.co/opportunities/_search?offset=0&size=100&aggregate=true";
            //var httpWebRequest = CreatePostHttpJsonRequest(url);
            var httpWebRequest = CreatePostHttpJsonRequest(String.Format(urlSearchJobs, offset, size, aggregate) + "&" + keyword);
            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
                //String jsonReq = "{\"offset\":\"1\"," +
                //              "\"size\":\"5\"," +
                //              "\"aggregate\":\"false\"," +
                //              "\"name\":\"" + keyword + "\"}";

                //string jsonReq = "{\"offset\":\"0\"," +
                //                "\"size\":\"100\"}"; 
                //string jsonReq = new JavaScriptSerializer().Serialize(new
                //{
                //    offset = 1,
                //    size = 100,
                //    aggregate = true
                //});

            //    streamWriter.Write(jsonReq);
            //}

            var writeStatus = WriteRequestResponse(httpWebRequest, JsonFileSearchJobs);
            return LoadJsonFile(JsonFileSearchJobs, 1);
        }
        public static Object SearchUsersByKeyword(string keyword, int offset, int size, Boolean aggregate)
        {
            var httpWebRequest = CreatePostHttpJsonRequest(String.Format(urlSearchUsers, offset, size, aggregate) + "&" + keyword);

            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    string jsonReq = "{\"name\":\"" + keyword + "\"}";

            //    streamWriter.Write(jsonReq);
            //}

            var writeStatus = WriteRequestResponse(httpWebRequest, JsonFileSearchUsers);
            return LoadJsonFile(JsonFileSearchUsers, 2);
        }


        public static Object SearchJob(String jobId)
        {
            using (WebClient wc = new WebClient())
            {
                String strJob = urlSearchJob + jobId;
                String strJobTorre = wc.DownloadString(strJob);
                File.WriteAllText(JsonFileJob, strJobTorre);
                // store all data from the given file into a data variable
                var dataJob = File.ReadAllText(JsonFileJob);

                // deserialize data. After deserialization, our object json will be 
                // populated with information from JSON file
                var serializer = new JavaScriptSerializer();
                var jsonJob = serializer.Deserialize<TorreJobVO>(dataJob);
                return jsonJob;
            }
        }
        public static Object SearchUser(String username)
        {
            using (WebClient wc = new WebClient())
            {
                String strURL = urlSearchUser + username;
                String strUserTorre = wc.DownloadString(strURL);
                File.WriteAllText(JsonFileUser, strUserTorre);
                // store all data from the given file into a data variable
                var dataUser = File.ReadAllText(JsonFileUser);

                // deserialize data. After deserialization, our object json will be 
                // populated with information from JSON file
                var serializer = new JavaScriptSerializer();
                var jsonUser = serializer.Deserialize<TorreUserVO>(dataUser);
                return jsonUser;
            }
        }

        private static HttpWebRequest CreatePostHttpJsonRequest(String urlAPIService)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(urlAPIService);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            return httpWebRequest;
        }
        private static Boolean WriteRequestResponse(HttpWebRequest httpWebRequest, string jsonFilePath)
        {
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                File.WriteAllText(jsonFilePath, result);
                return true;
            }
        }

        private static Object LoadJsonFile(string jsonFilePath, int type)
        {
            var dataSearch = File.ReadAllText(jsonFilePath);
            var serializer = new JavaScriptSerializer();
            var jsonSearchResults = new Object();
            switch (type)
            {
                case 1:
                    jsonSearchResults = serializer.Deserialize<TorreSearchJobVO>(dataSearch);
                    break;
                case 2:
                    jsonSearchResults = serializer.Deserialize<TorreSearchUserVO>(dataSearch);
                    break;
                default:
                    jsonSearchResults = serializer.Deserialize<dynamic>(dataSearch);
                    break;
            }
            return jsonSearchResults;
        }
    }
}
