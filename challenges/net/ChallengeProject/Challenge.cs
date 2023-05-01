using System;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Azure.Cosmos;

namespace ChallengeProject
{
    public class Challenge
    {

        public void InitConnection()
        {
            CosmosClient client = new CosmosClient("");

            //Create telemetryConfiguration for application insights
            TelemetryConfiguration telemetryConfiguration = new TelemetryConfiguration();
            telemetryConfiguration.ConnectionString = "";
            TelemetryClient telemetryClient = new TelemetryClient(telemetryConfiguration);


            //create a database called "challengedb"
           

            //create a container called "challengecontainer" in the database
          

            //create a new item in the container, that has these fields: name, surname, age, id
            

            //insert the item into the container
           

            //query the container for a single item that name = "John"
           

            //execute the query
           

            //get the first item from the query result
            

            //print the name field to the console
            

            //send the result to application insights
           

            //flush the telemetry client
            





        }         





    }
}
