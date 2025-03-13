using BitrateCalculate.Models;
using Newtonsoft.Json;
using System.Linq.Expressions;

public class Program
{

    public static void Main()
    {
        string apiResponse = GetData();

        if (apiResponse == null)
        {
            throw new Exception("Unable to get data.");
        }

        ResponseModel response = JsonConvert.DeserializeObject<ResponseModel>(apiResponse);

        if (response == null)
        {
            throw new NullReferenceException("Unable to parse response.");
        }

        foreach (var item in response.Nic)
        {
            Console.WriteLine($"Bitrate for Rx {item.Rx} is {CalculateBitrate(item.Rx)} Mbps");
            Console.WriteLine($"Bitrate for Tx {item.Tx} is {CalculateBitrate(item.Tx)} Mbps");
        }
    
    }

    private static string GetData()
    {
        return  """  
                    {
                     "Device": "Arista",
                     "Model": "X-Video",
                     "NIC": [{
                                "Description": "Linksys ABR",
                                "MAC": "14:91:82:3C:D6:7D",
                                "Timestamp": "2020-03-23T18:25:43.511Z",
                                "Rx": "3698574500",
                                "Tx": "122558800"
                            }]
                    }
                """;

    }


    private static double CalculateBitrate(long value)
    {
        const int polingRate = 2;
        long bitValue = ConvertToBits(value);

        return (bitValue * polingRate) / 1000000.0;
    }

    private static long ConvertToBits(long byteValue)
    {
        return byteValue * 8;
    }

}