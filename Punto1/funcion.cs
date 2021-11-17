#r "Newtonsoft.Json"//

using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

public static async Task<IActionResult> Run(HttpRequest req, ILogger log)
{

    string requestBody = String.Empty;
    using (StreamReader streamReader =  new  StreamReader(req.Body))
    {
        requestBody = await streamReader.ReadToEndAsync();
    }

    dynamic score = JsonConvert.DeserializeObject(requestBody);
    string value = "Verde";

    if(score < 0.3)
    {
        value = "Rojo";
    }
    else if (score < 0.6) 
    {
        value = "Amarillo";
    }

    return requestBody != null
        ? (ActionResult)new OkObjectResult(value)
       : new BadRequestObjectResult("Pass a sentiment score in the request body.");
}
