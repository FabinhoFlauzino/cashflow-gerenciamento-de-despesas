namespace CashFlow.Communication.Responses;

public class ResponseErrorJson
{
<<<<<<< HEAD
    public string ErrorMessage { get; set; } = string.Empty;
    
    public ResponseErrorJson(string errorMessage)
    {
        ErrorMessage = errorMessage;  
=======
    public List<string> ErrorMessages { get; set; }
    public ResponseErrorJson(string errorMessage)
    {
        ErrorMessages = [errorMessage];
    }

    public ResponseErrorJson(List<string> errorMessage)
    {
        ErrorMessages = errorMessage;
>>>>>>> 3c4592dcec1325eb6bfb4dd71055d8d75383691d
    }
}
