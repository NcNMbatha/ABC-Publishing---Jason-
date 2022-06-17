using ABCPublication.Web.Interface;
using ABCPublication.Web.Models;
using Newtonsoft.Json;

namespace ABCPublication.Web.Services
{
    public class JsonService : IJsonService
    {
        public JsonRoot LoadJsonData()
        {
            var root = new JsonRoot();
            using (StreamReader r = new StreamReader("json-content-file.json"))
            {
                string json = r.ReadToEnd();
                root = JsonConvert.DeserializeObject<JsonRoot>(json);
            }

            return root;
        }

        public override bool Equals(Object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            var jsonRootModel = obj as JsonRoot;

            return jsonRootModel.Preface.Title == LoadJsonData().Preface.Title;
        }
    }
}
