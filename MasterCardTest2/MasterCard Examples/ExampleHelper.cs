using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterCard.Core.Model;
using Newtonsoft.Json.Linq;

namespace MasterCardTest.MasterCard_Examples {
    public static class ExampleHelper {

        public static void DisplayResponse(IEnumerable<KeyValuePair<string, object>> resp, string key = "") {
            foreach(KeyValuePair<string, object> o in resp) {
                if(o.Value is Dictionary<string, object>) {
                    DisplayResponse(o.Value as Dictionary<string, object>, key + o.Key + ".");
                } else if(o.Value is JObject) {
                    DisplayResponseJObject(o.Value as JObject, key + o.Key + ".");
                } else if(o.Value is IList) {
                    DisplayResponseList(o.Value as IList, key + o.Key);
                } else {
                    Console.WriteLine(key + o.Key + " --> " + Convert.ToString(o.Value));
                }
            }
        }


        public static void DisplayResponseJObject(JObject resp, string key = "") {
            foreach(KeyValuePair<string, JToken> o in resp) {
                if(o.Value.HasValues) {
                    foreach(var v in o.Value) {
                        if(v is JProperty) {
                            if((v as JProperty).Value is JObject) {
                                DisplayResponseJObject((v as JProperty).Value as JObject, key + o.Key + "." + (v as JProperty).Name + ".");
                            } else if ((v as JProperty).Value is JArray) {
                                DisplayResponseList((v as JProperty).Value as IList, key + o.Key + "." + (v as JProperty).Name);
                            } else {
                                Console.WriteLine(key + o.Key + "." + (v as JProperty).Name + " --> " + Convert.ToString((v as JProperty).Value));
                            }
                        } else if(v is JObject) {
                            DisplayResponseJObject(v as JObject, key + o.Key + ".");
                        } else if (v is JArray) {
                            DisplayResponseList(v as IList, key + o.Key);
                        } else {
                            var t = v.GetType();
                        }

                    }
                }
            }
        }


        public static void DisplayResponseList(IList resp, string key = "") {
            for(int i = 0; i < resp.Count; i++) {
                if(resp[i] is Dictionary<string, object>) {
                    DisplayResponse(resp[i] as Dictionary<string, object>, key + "[" + i.ToString() + "].");
                } else if(resp[i] is JObject) {
                    DisplayResponseJObject(resp[i] as JObject, key + "[" + i.ToString() + "].");
                }else if(resp[i] is JProperty) {
                    if((resp[i] as JProperty).Value is JObject) {
                        DisplayResponseJObject((resp[i] as JProperty).Value as JObject, key + "[" + i.ToString() + "]." + (resp[i] as JProperty).Name + ".");
                    } else if((resp[i] as JProperty).Value is JArray) {
                        DisplayResponseList((resp[i] as JProperty).Value as IList, key + "[" + i.ToString() + "]." + (resp[i] as JProperty).Name);
                    } else {
                        Console.WriteLine(key + "[" + i.ToString() + "]." + (resp[i] as JProperty).Name + " --> " + Convert.ToString((resp[i] as JProperty).Value));
                    }
                } else if(resp[i] is IList) {
                    DisplayResponseList(resp[i] as IList, key + "[" + i.ToString() + "]");
                } else {
                    Console.WriteLine(key + "[" + i.ToString() + "] --> " + Convert.ToString(resp[i]));
                }
            }
        }
    }
}
