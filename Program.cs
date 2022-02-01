using RestSharp;
using System;
using System.Diagnostics;

namespace AppConsolaAPIManager
{
    class Program
    {
        static void Main(string[] args)
        {

            String url = "https://transpcargo.rexmas.cl/api/v2/aliados/configuracion/cambiar_clave";
            // String url = "https://transpcargo.rexmas.cl/api/v2/aliados/configuracion/recuperar_token";
            //esto es para cambiar la clave

            Console.WriteLine(url);
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Token eyJpZCI6NTkxLCJ2YWxpZCI6MiwidXNlcm5hbWUiOiJ0cmFuc3BjYXJnbyIsImNyZWF0aW9uX3RpbWUiOjE2NDM2NjY1NzQuMjYwMTc5fQ.vAPvyCkrHbhXRsbiyrOurvNM6GpbmF-N1mRiJp-_OSc");
            var body = @"{" + "\n" +
            @"	""clave_antigua"": ""E7Dw00fWOA7LDi3L""," + "\n" +
            @"	""clave_nueva"": ""CARGOtcp2022!""," + "\n" +
            @"	""confirmacion_clave_nueva"": ""CARGOtcp2022!""" + "\n" +
            @"}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            //Esto es para obtener token
            //var client = new RestClient(url);
            //client.Timeout = -1;
            //var request = new RestRequest(Method.PUT);
            //request.AddHeader("Content-Type", "application/json");
            //var body = @"{" + "\n" +
            //@"    ""usuario"": ""transpcargo""," + "\n" +
            //@"    ""clave"": ""E7Dw00fWOA7LDi3L""" + "\n" +
            //@"}";
            //request.AddParameter("application/json", body, ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
            //Debug.WriteLine(response.Content);

            //token es
            //eyJpZCI6NTkxLCJ2YWxpZCI6MiwidXNlcm5hbWUiOiJ0cmFuc3BjYXJnbyIsImNyZWF0aW9uX3RpbWUiOjE2NDM2NjY1NzQuMjYwMTc5fQ.vAPvyCkrHbhXRsbiyrOurvNM6GpbmF-N1mRiJp-_OSc





        }
    }
}
