# JsonFile

The given code demonstrates reading a JSON file, parsing its contents using Newtonsoft.Json library, and performing various operations on the data. The JSON file contains information about neighborhoods, and the code extracts and manipulates the neighborhood data.

## To use the code:

- Make sure you have the Newtonsoft.Json library referenced in your project.
- Create a JSON file containing the neighborhood data and provide its path in the jsonFilePath variable.
- Define the classes Feature, Geometry, Properties, and Root as shown in the code snippet.
- Use the Main method as an entry point for your program.
Run the program.

The code will read the JSON file, deserialize it into a Root object, and perform the following operations on the neighborhood data:

- Extract all neighborhoods and display them along with the total count.
- Filter out named neighborhoods (non-null and non-empty) and display them along with the count.
- Extract distinct neighborhoods from the named neighborhoods and display them along with the count.
- Consolidate the neighborhoods using LINQ query syntax and display them along with the count.


Summary:

The given code demonstrates reading a JSON file, parsing its contents using Newtonsoft.Json library, and performing various operations on the data. The JSON file contains information about neighborhoods, and the code extracts and manipulates the neighborhood data.

Visuals:
There are no visuals provided in the code snippet.

Usage:
To use the code:

Make sure you have the Newtonsoft.Json library referenced in your project.
Create a JSON file containing the neighborhood data and provide its path in the jsonFilePath variable.
Define the classes Feature, Geometry, Properties, and Root as shown in the code snippet.
Use the Main method as an entry point for your program.
Run the program.
The code will read the JSON file, deserialize it into a Root object, and perform the following operations on the neighborhood data:

Extract all neighborhoods and display them along with the total count.
Filter out named neighborhoods (non-null and non-empty) and display them along with the count.
Extract distinct neighborhoods from the named neighborhoods and display them along with the count.
Consolidate the neighborhoods using LINQ query syntax and display them along with the count.

## Other Details:

The code relies on the Newtonsoft.Json library for JSON deserialization.
It uses LINQ queries to manipulate the neighborhood data.
The Root class represents the root object of the JSON structure.
The Feature, Geometry, and Properties classes define the structure of the JSON data within the Root object.
The code outputs the results to the console.
