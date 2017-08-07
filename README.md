# CD_netCore_RApi_Rap_Api
Troy Center troycenter1@gmail.com August 2017
Coding Dojo .net Core and C# fundamentals. 

## RApi, The Rapper Api
Now that we are able to serve back JSON responses to web requests, we can do something interesting. In the previous section we worked with some records for artists and groups when practicing our LINQ knowledge. We are going to use those same collections again, but now we will provide endpoints for various requests for information from these data sets. What we are essentially doing is building our own external API from these collections. For this assignment we will be actively reinforcing our knowledge on LINQ, ASP.NET Core Method routing, and serving back JSON responses. Once again we will also provide a starter project from which to build from which can be downloaded by clicking the button below


<a href="https://s3.amazonaws.com/General_V88/boomyeah2015/codingdojo/curriculum/content/chapter/Starter_Ver2.zip">Download Assignment Skeleton Ver. 1.1</a> 

For this assignment the follow things are required:
<ul>
<li>Create a route for /artists that returns all artists as JSON</li>
<li>Create a route /artists/name/{name} that returns all artists that match the provided name</li>
<li>Create a route /artists/realname/{name} that returns all artists who real names match the provided name</li>
<li>Create a route /artists/hometown/{town} that returns all artists who are from the provided town</li>
<li>Create a route /artists/groupid/{id} that returns all artists who have a GroupId that matches id</li>
<li>Create a route /groups that returns all groups as JSON</li>
<li>Create a route /groups/name/{name} that returns all groups that match the provided name</li>
<li>Create a route /groups/id/{id} that returns all groups with the provided Id value</li>
<li>(Optional) Add an extra boolean parameter to the group routes called displayArtists that will include members for all Group JSON responses</li>
</ul>