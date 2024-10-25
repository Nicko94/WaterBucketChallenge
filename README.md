# Water Bucket Challenge RESTful API

## Overview
This API provides a solution to the classic water bucket challenge in which the task is to measure a target amount of water by filling, transferring and emptying two water buckets of a given capacity, ideally with the least amount of steps possible.

The project consists of three primary layers:

1 API Layer: Handles incoming requests (WaterBucketController).

2 Application Layer: Contains services and DTOs for request/response handling.

3 Domain layer: Includes the Node entity to represent the state in each step.


## Features
- Solve the water bucket challenge with two buckets and a target amount.
- Returns detailed steps in the solution path or errors when invalid inputs are provided.
- Error handling for edge cases like when there's no solution possible or the input values are invalid.

Table of contents
1. Setup
2. How to Run
3. API Endpoints
4. Algorithm explanation
5. Example Requests and Responses

Setup

Prerequisites
. .NET Core SDK installed
. A code editor like Visual Studio (2022 version used)

Installation
1. Clone the repository
```
git clone https://github.com/Nicko94/WaterBucketChallenge.git
cd WaterBucketChallenge
```
3. Restore the dependencies:
   dotnet restore
4. Build the project
   dotnet build
   
How to Run
1. Navigate to the project's directory:
   cd WaterBucketChallenge.API
2. Start the API:
   dotnet run
3. The API will run on http://localhost:5000. You can now send request using Swagger or similar tools like Postman

API Endpoints
POST /solve
This endpoint solves the water bucket problem for the given bucket sizes and target volume.



 Algorithm implementation

 Entities layer
