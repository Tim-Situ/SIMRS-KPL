using System;
namespace SIMRS_API;

public class ApiResponse<T>
{
	public bool success { get; set; } = true;
	public string message { get; set; }
	public T data { get; set; }

	//public ApiResponse(bool success, string message, List<T> data)
	//{
	//	this.success = success;
	//	this.message = message;
	//	this.data = data;
	//}
}

