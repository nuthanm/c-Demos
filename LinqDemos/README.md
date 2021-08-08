## About LINQ
1. LINQ stands Language Integrated Query
2. Use LINQ to work on Objects,XML,Datasets,Jsons,Databases
3. Syntax of LINQ is similar like SQL
4. LINQ can use in C# and VB

### Write Linq queries in two ways
1. Query Syntax: from,where,select
2. Method Syntax: using Methods with lamda expression(=>)

### What can we do with Linq
1. GetAll Columns
2. GetSpecific Columns
3. OrderBy - Either by Single or More than one field
   - Descending
   - Ascending - **Default**
4.  Filtering Records
   - Using Single Column
   - Using more than one column separation with operators (&&,||)
   - Create our own Extension method to filter
5. Select a single item - Use anyone of the following options to get.
   - First()/FirstOrDefault()
   - Last()/LastOrDefault()
   - Single()/SingleOrDefault()
   - Difference between these ?
     - First()/Last()/Single()/SingleorDefault() - Explicity add catch when there is no records or more than one records.
