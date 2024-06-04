using User_Utility;

namespace dotNet_FrontMVC.Models;

public class ApiRequest
{
    public StaticDetails.ApiType ApiType { get; set; } = StaticDetails.ApiType.GET;
    public string Url { get; set; } 
    public object Data { get; set; } 
}