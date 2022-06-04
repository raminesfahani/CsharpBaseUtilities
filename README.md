Here we have set of utilities and extensions functions to facilitate sort of calculation and conversion for coding less.

## Environment Variables `.env`
### Get Environment Variables as Object with Values
Using `DotEnv`.`Load<T>()` you can get object of variables set in environment variables.

```C#

// Instance of Settings
public class SampleSettings
{
    public string StringValue { get; set; }
    public int IntValue  { get; set; }
    public uint UIntValue  { get; set; }
    public long LongValue  { get; set; }
    public ulong ULongValue  { get; set; }
}

public void GetEnvModelObj()
{
    SampleSettings workerSettings = DotEnv.Load<SampleSettings>();
}
```

# Utilities

Extensions and tools:

### `String`.`ToConstantCase()`
```C#
public void ToConstantCase(string value)
{
    string calculated = value.ToConstantCase(true); //Expected: "CONSTANT_NAMING_CONVENTION"
}
```

### `object`.`GetQueryString()`
turn object into a Web GET query string.

Usage:
```C#
SampleObject sampleObject = new SampleObject()
{
    Name = "Ramin Esfahani",
    Age = 31,
    PropertyNull = null,
    Value = "Value 123!@#$%^&*()"
};

string result = sampleObject.GetQueryString(); //Expected: "Name=Ramin+Esfahani&Age=31&Value=Value+123!%40%23%24%25%5E%26*()"

```

## Extensions
### `String`.`ToSnakeCase()`
Change any case to snake case.
```C#
public void ToSnakeCase(string value)
{
    string calculated = value.ToSnakeCase(); //Expected: "constant_naming_convention"
}
```