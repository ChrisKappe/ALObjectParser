﻿using System.Collections.Generic;

namespace ALObjectParser.Library
{
    public interface IALObject
    {
        int Id { get; set; }
        ALObjectType Type { get; set; }
        string Name { get; set; }
        ICollection<ALMethod> Methods { get; set; }
        ICollection<ITestFeature> Features { get; set; }
        ICollection<ALProperty> Properties { get; set; }
    }
}