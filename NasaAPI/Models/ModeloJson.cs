
using System.Collections.Generic;

public class Rootobject
{
    public List<Todos> datos { get;set; }
}

public class Todos
{
    public Links links { get; set; }
    public int element_count { get; set; }
    public Near_Earth_Objects near_earth_objects { get; set; }
}
public class Links
{
    public string next { get; set; }
    public string prev { get; set; }
    public string self { get; set; }
}

public class Near_Earth_Objects
{
    public List<Fecha> fecha { get; set; }
}

public class Fecha
{
    public Links1 links { get; set; }
    public string id { get; set; }
    public string neo_reference_id { get; set; }
    public string name { get; set; }
    public string nasa_jpl_url { get; set; }
    public float absolute_magnitude_h { get; set; }
    public Estimated_Diameter estimated_diameter { get; set; }
    public bool is_potentially_hazardous_asteroid { get; set; }
    public Close_Approach_Data[] close_approach_data { get; set; }
    public bool is_sentry_object { get; set; }
}

public class Links1
{
    public string self { get; set; }
}

public class Estimated_Diameter
{
    public Kilometers kilometers { get; set; }
    public Meters meters { get; set; }
    public Miles miles { get; set; }
    public Feet feet { get; set; }
}

public class Kilometers
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Meters
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Miles
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Feet
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Close_Approach_Data
{
    public string close_approach_date { get; set; }
    public string close_approach_date_full { get; set; }
    public long epoch_date_close_approach { get; set; }
    public Relative_Velocity relative_velocity { get; set; }
    public Miss_Distance miss_distance { get; set; }
    public string orbiting_body { get; set; }
}

public class Relative_Velocity
{
    public string kilometers_per_second { get; set; }
    public string kilometers_per_hour { get; set; }
    public string miles_per_hour { get; set; }
}

public class Miss_Distance
{
    public string astronomical { get; set; }
    public string lunar { get; set; }
    public string kilometers { get; set; }
    public string miles { get; set; }
}



public class Links2
{
    public string self { get; set; }
}

public class Estimated_Diameter1
{
    public Kilometers1 kilometers { get; set; }
    public Meters1 meters { get; set; }
    public Miles1 miles { get; set; }
    public Feet1 feet { get; set; }
}

public class Kilometers1
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Meters1
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Miles1
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Feet1
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Close_Approach_Data1
{
    public string close_approach_date { get; set; }
    public string close_approach_date_full { get; set; }
    public long epoch_date_close_approach { get; set; }
    public Relative_Velocity1 relative_velocity { get; set; }
    public Miss_Distance1 miss_distance { get; set; }
    public string orbiting_body { get; set; }
}

public class Relative_Velocity1
{
    public string kilometers_per_second { get; set; }
    public string kilometers_per_hour { get; set; }
    public string miles_per_hour { get; set; }
}

public class Miss_Distance1
{
    public string astronomical { get; set; }
    public string lunar { get; set; }
    public string kilometers { get; set; }
    public string miles { get; set; }
}



