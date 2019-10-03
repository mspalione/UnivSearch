# UnivSearch
A styled webpage from the data acquired that displays name, title, phone number and web address for all Kentucky records in a table that is both searchable and sortable using JavaScript from the data set provided on: https://inventory.data.gov/dataset/032e19b4-5a90-41dc-83ff-6e4cd234f565/resource/38625c3d-5388-4c16-a30f-d105432553a4. Add a new school using C#. Search for a school with Javascript.

I have never used SQL before and was advised by a mentor to not try to learn it for this project given the time restraints. 
I think using a database would have made things simpler and smoother and look forward to learning SQL in the future.

I started by downloading the information from data.gov as a csv file. 
I then created a MVC solution in Visual Studio. (This was my first exposure to MVC. Up until this point I have only made console apps.)
I started with a University model setting each field for what would be needed to retrieve from the csv file.
I added Univ.csv to the Content folder.
I used HomeController to convert the csv file to Json, first searching for KY and then pulling the Name, Title, Phone Number and Website from relevant fields through array placement.
In Index.cshtml I set up the table using ajax to get the data needed to fill in the cells.
I then used javascript to accomplish the goals of a searchable and sortable table.
I finished with adding style in Index.cshtml and Site.css such as background color, image in the jumbotron,
google font for the h1 adding shadow, and another image featuring opacity.
The headers of each column in the table will lighten and the cursor turns to a pointer on hover to signal the user that it is clickable, which is how to sort the table.
I created a stylized search bar including a magnifying glass image and finished with a gif at the bottom of the page.

One complication from using a csv file is in fact the comma seperated values. Some of the names in "Head of Institution" had a comma separating additional letters after his or her name, such as PhD.
As a result, the remainder of the fields for that row are off by one making incorrect values in the rest of the fields.
I believe this would not be a factor pulling json directly from site and storing in a database, which is what I would do to improve on the project.

The functions of the site were tested and work in Chrome, Firefox and Edge.

If you have difficulties getting this to run on your machine, after you clone the project try right clicking on the solution and select Clean Solution. Then right click on it again and select Rebuild Solution.
