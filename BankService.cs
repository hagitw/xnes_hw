using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Script.Serialization;
using xnes_hw.Models;

namespace xnes_hw
{
    public class BankService
    {
        dynamic data;
        string json;
        public List<Bank> GetBanks()
        {
          
            List<Bank> Banks = new List<Bank>();

            try
            {
                GetJsonBank();
                dynamic obj = JObject.Parse(json);
                data = obj.Data;
                string bankJosn = data["Banks"].ToString();
                var b = JsonConvert.DeserializeObject<Bank[]>(bankJosn).ToList(); 

                return b.ToList();


                //GetJsonBank();
                //jsonBankBranchs = GetJsonByCategory("Banks");
                //var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Bank[]>(jsonBankBranchs);
                //Banks = obj.ToList();

            }
            catch (Exception e)
            {

                //todo:logger
            }
            return Banks;
        }
        //public IEnumerable<Bank> GetBanksIEnumerable()
        //{
        //    string jsonBankBranchs = string.Empty;
        //    List<Bank> Banks = new List<Bank>();

        //    try
        //    {
        //        GetJsonBank();
        //        jsonBankBranchs = GetJsonByCategory("Banks");
        //        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Bank[]>(jsonBankBranchs);
        //        Banks = obj.ToList();

        //    }
        //    catch (Exception e)
        //    {

        //        //todo:logger
        //    }
        //    return Banks;
        //}

        public List<BankBranch> GetBankBranchs()
        {
                
            string jsonBankBranchs = string.Empty;
            List<BankBranch> BankBranch = new List<BankBranch>();

            try
            {
                GetJsonBank();
                dynamic obj = JObject.Parse(json);
                data = obj.Data;
                string BankBranchsJosn = data["BankBranches"].ToString();
                var ob = JsonConvert.DeserializeObject<BankBranch[]>(BankBranchsJosn);
                return ob.ToList();
              
            }
            catch (Exception e)
            {

                //todo:logger 
            }
            return BankBranch;
        }
        private void GetJsonBank()
        {
            //try
            //{
            //    if (data == null)
            //    {
            //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Common.BankApi);

            //        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //        using (Stream stream = response.GetResponseStream())
            //        using (StreamReader reader = new StreamReader(stream))
            //        {
            //            var JsonBank = reader.ReadToEnd();
            //                 data = JObject.Parse(JsonBank.ToString());

            //        }

            //    }
            //    //data = JObject.Parse(JsonBank.ToString());

            //}
            //catch (Exception e)
            //{

            //    //todo:logger 
            //}
            //
            string text = string.Empty;
            try
            {
                json = System.IO.File.ReadAllText(@"C:\Users\חגית\Desktop\json.txt");

            }
            catch (Exception e)
            {

                throw;
            }
            
        }

        private string GetJsonByCategory(string category)
        {
            string jsonCategory = string.Empty;
            try
            {
                jsonCategory = data[category].ToString();

            }
            catch (Exception e)
            {

                //todo:logger 
            }
            return jsonCategory;

        }



    }
}