<h1 align="center">Digital Music Library</h1>
<h3 align="center">using .NET (C#), Entity Framework, SQL, Angular & NgRx</h3>

<h3 align="left"> Guide & Use</h3>
  
-  Setting-up the project

-  Further implementations
  
-  Discussions & Conclusions

<h3 align="left">Setting-up the project</h3>
<p align="left">
First, we want to download the project <a href="https://nodejs.org/ro">locally</a>. To do that, we need to go to <a href="[https://github.com/manubmxnsb/DigitalMusicLibrary]">its repository </a>, click on <b>CODE</b> and copy the <b>path</b>.
</p>
<p align="left">
Once that's done, we can go to our prefered folder, open <b>Git Bash</b> and enter <code>git clone [repo-link]</code>.
</p>
<p>Now we need to enter Visual Studio Code. By importing the project, we will have all the NuGet Packages pre-installed in the project so we don't need to worry about them. We just need to create a <b>local database</b> with the same name as the project, in our case its "DigitalMusicLibrary". Once that's done, please open the package explorer terminal. We now need to seed our database using <code>update-database</code> and <code></code>add-migrations</code>.
</p>
<p>For safety, we should check if our database is now populated. If it is, then the project is now fully set-up</p>

<p>All we need to do now to start the project is to estamblish the connection between the Backend Server, SQL and Frontend. There are 3 steps here:
</p>
<ol>
<li>We need to connect to our local DB (using Microsoft SQL Server Management Studio)</li>
  <li>Start our Backend project using Visual Studio</li>
  <li>Start our Frontend project using <code>ng serve </code></li>
</ol>
<h3 align="left">Further implementations</h3>
<p>All that's left is to implement the other CRUD operations in the Frontend side and finish the autocorrect. The process is the same as with the READ operation, the only difference is that for the others, we also send back data as response to the Backend side, which will go through the Middleware then our DTO's, converting them to Entities through our controller, and ultimatelly update the database based on the changes from <b>the request</b>.
</p>
<p>Besides this, I think there can be improvements on the code side. Modularization of certain functions such as <code>SeedData.cs</code> and changing names in my <code>.HTML</code> and <code>.CSS</code> classes to have a certain standard and be more readable by the team. 
</p>
<p>

<h3 align="left">Discussions & Conclusions</h3>
<p>Overall, this has been an amazing experience! I thank you for the opportunity and I'm sad I didn't have the time to finish the whole assignment. Thank you so much & hopefully talk to you soon!</p>


