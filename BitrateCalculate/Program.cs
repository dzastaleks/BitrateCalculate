﻿public class Program
{

    public static void Main()
    {
        string apiResponse = GetData();    
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

}