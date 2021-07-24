## About Extension Method

In breif, we are extending the functionality to the existing object.

**Ex:** Consider there is no method available to get two characters at a time from a text using string object.
Using this extension method, we can acheive this functionality.

**How do you identify which method is extension method?**

Mainly three factors we keep in mind,

1. Class should be **static**
2. Method should be **static**
3. Method first parameter has **this** keyword

Sample code and syntax for Extension Methods,

**Syntax for Extension Method**
~~~
public static <returnType> <MethodName>(this <dataType> nameOftheParameter,[OptionalParameters])
{
   // Write your own logic
   
}
~~~

**Example for Extension Method**
~~~
public static void LogInformation(this string message)
{
   Console.WriteLine(message);   
}
~~~

**Note:** Generic Extension Methods also possible.

**Reference Video Url:**

https://www.youtube.com/watch?v=C_1DzspLy4Y
