using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Net;
/// <summary>
/// Summary description for SmileAPIClient
/// </summary>
public class SmileAPIClient
{
    private const string URL = "http://api.smilesn.com/session";
    private string urlParameters = "?username=10&password=tree8531";

	public SmileAPIClient()
	{
	}

    private SMSSession GetSession()
    {
        string url = URL + urlParameters;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        if (response.StatusCode == HttpStatusCode.OK)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(SMSSession));
            SMSSession session = (SMSSession)jsonSerializer.ReadObject(response.GetResponseStream());
            return session;
        }
        else
            return null;
    }

    private bool SendSMS(SMSSession session, string receivenum, string textmessage)
    {
        string url = "http://api.smilesn.com/sendsms?sid=" + session.sessionid + "&receivenum=" + receivenum + "&sendernum=8333&textmessage=" + textmessage;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        if (response.StatusCode == HttpStatusCode.OK)
        {
            return true;
        }
        else
            return false;
    }

    private ALLReciveMessage ReciveSMS(SMSSession session)
    {
        string url = "http://api.smilesn.com/receivesms?sid=" + session.sessionid;
        ALLReciveMessage allmessages = new ALLReciveMessage();
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        if (response.StatusCode == HttpStatusCode.OK)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(ALLReciveMessage));
            allmessages = (ALLReciveMessage)jsonSerializer.ReadObject(response.GetResponseStream());
        }
        else
            return null;

        return allmessages;
    }
}

public class SMSSession
{
    public string sessionid { get; set; }
}

public class Status
{
    public string id { get; set; }
    public string sender_num { get; set; }
    public string receiver_num { get; set; }
    public string gsm_network { get; set; }
    public string time { get; set; }
    public string text { get; set; }
}

public class ALLReciveMessage
{
    public List<Status> status { get; set; }
}