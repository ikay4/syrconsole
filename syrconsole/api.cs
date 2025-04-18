using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using GraphQL.Client;
using GraphQL.Client.Http;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Serializer.SystemTextJson;
using GraphQL.Client.Abstractions.Utilities;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace syrconsole
{
    public partial class api

    {
        // Define the classes for the GraphQL response (Start)

        // Verify Key
        public class Player
        {
            public string GamerTag { get; set; }
        }

        public class CurrentUser
        {
            public Player Player { get; set; }
        }

        public class AuthUserResponse
        {
            public CurrentUser CurrentUser { get; set; }
        }



        // (End)

        // Variables
        public static class apiGlobals
        {
            // General
            public static String apiKey { get; set; }
            public static GraphQLHttpClientOptions clientOptions = new GraphQLHttpClientOptions()
            {
                EndPoint = new Uri("https://api.start.gg/gql/alpha"),
                MediaType = "application/json"
            };
            public static GraphQLHttpClient client { get; set; } = new GraphQLHttpClient(clientOptions, new SystemTextJsonSerializer());
            public static String response { get; set; }

            // Verify Key

        }

        // Tasks
        public static async Task<Boolean> verifyKey()
        {
            try
            {
                apiGlobals.client.HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiGlobals.apiKey}");
                var request = new GraphQLRequest
                {
                    Query = @"query authUser {
                        currentUser {
                            player {
                                gamerTag
                            }
                        }
                    }"
                };
                Console.WriteLine("Calling API (Verifying Key)...");
                var apiResponse = await apiGlobals.client.SendQueryAsync<AuthUserResponse>(request);
                if (apiResponse.Errors != null)
                {
                    foreach (var error in apiResponse.Errors)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Error: {error.Message}");
                    }
                }
                Console.WriteLine("API Response: {0}", apiResponse.Data);
                apiGlobals.response = apiResponse.Data.CurrentUser.Player.GamerTag;
                return true;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERROR!!! >> API Key failed to return any data. Is your API key valid?");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
    }
}
