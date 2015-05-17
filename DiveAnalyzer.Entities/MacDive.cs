
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class dives
{

    private string unitsField;

    private string schemaField;

    private divesDive diveField;

    /// <remarks/>
    public string units
    {
        get
        {
            return unitsField;
        }
        set
        {
            unitsField = value;
        }
    }

    /// <remarks/>
    public string schema
    {
        get
        {
            return schemaField;
        }
        set
        {
            schemaField = value;
        }
    }

    /// <remarks/>
    public divesDive dive
    {
        get
        {
            return diveField;
        }
        set
        {
            diveField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class divesDive
{

    private string dateField;

    private string identifierField;

    private byte diveNumberField;

    private byte ratingField;

    private string countryField;

    private string locationField;

    private string siteField;

    private byte repetitiveDiveField;

    private decimal siteLatField;

    private decimal siteLonField;

    private string diverField;

    private string computerField;

    private uint serialField;

    private decimal maxDepthField;

    private decimal averageDepthField;

    private decimal cnsField;

    private string decoModelField;

    private ushort durationField;

    private string gasModelField;

    private byte surfaceIntervalField;

    private byte sampleIntervalField;

    private decimal tempAirField;

    private decimal tempHighField;

    private decimal tempLowField;

    private object visibilityField;

    private object weatherField;

    private object weightField;

    private string notesField;

    private object diveMasterField;

    private object diveOperatorField;

    private object skipperField;

    private object boatField;

    private object tagsField;

    private object typesField;

    private object buddiesField;

    private divesDiveItem[] gearField;

    private divesDiveGases gasesField;

    private divesDiveSample[] samplesField;

    /// <remarks/>
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }

    /// <remarks/>
    public string identifier
    {
        get
        {
            return identifierField;
        }
        set
        {
            identifierField = value;
        }
    }

    /// <remarks/>
    public byte diveNumber
    {
        get
        {
            return diveNumberField;
        }
        set
        {
            diveNumberField = value;
        }
    }

    /// <remarks/>
    public byte rating
    {
        get
        {
            return ratingField;
        }
        set
        {
            ratingField = value;
        }
    }

    /// <remarks/>
    public string country
    {
        get
        {
            return countryField;
        }
        set
        {
            countryField = value;
        }
    }

    /// <remarks/>
    public string location
    {
        get
        {
            return locationField;
        }
        set
        {
            locationField = value;
        }
    }

    /// <remarks/>
    public string site
    {
        get
        {
            return siteField;
        }
        set
        {
            siteField = value;
        }
    }

    /// <remarks/>
    public byte repetitiveDive
    {
        get
        {
            return repetitiveDiveField;
        }
        set
        {
            repetitiveDiveField = value;
        }
    }

    /// <remarks/>
    public decimal siteLat
    {
        get
        {
            return siteLatField;
        }
        set
        {
            siteLatField = value;
        }
    }

    /// <remarks/>
    public decimal siteLon
    {
        get
        {
            return siteLonField;
        }
        set
        {
            siteLonField = value;
        }
    }

    /// <remarks/>
    public string diver
    {
        get
        {
            return diverField;
        }
        set
        {
            diverField = value;
        }
    }

    /// <remarks/>
    public string computer
    {
        get
        {
            return computerField;
        }
        set
        {
            computerField = value;
        }
    }

    /// <remarks/>
    public uint serial
    {
        get
        {
            return serialField;
        }
        set
        {
            serialField = value;
        }
    }

    /// <remarks/>
    public decimal maxDepth
    {
        get
        {
            return maxDepthField;
        }
        set
        {
            maxDepthField = value;
        }
    }

    /// <remarks/>
    public decimal averageDepth
    {
        get
        {
            return averageDepthField;
        }
        set
        {
            averageDepthField = value;
        }
    }

    /// <remarks/>
    public decimal cns
    {
        get
        {
            return cnsField;
        }
        set
        {
            cnsField = value;
        }
    }

    /// <remarks/>
    public string decoModel
    {
        get
        {
            return decoModelField;
        }
        set
        {
            decoModelField = value;
        }
    }

    /// <remarks/>
    public ushort duration
    {
        get
        {
            return durationField;
        }
        set
        {
            durationField = value;
        }
    }

    /// <remarks/>
    public string gasModel
    {
        get
        {
            return gasModelField;
        }
        set
        {
            gasModelField = value;
        }
    }

    /// <remarks/>
    public byte surfaceInterval
    {
        get
        {
            return surfaceIntervalField;
        }
        set
        {
            surfaceIntervalField = value;
        }
    }

    /// <remarks/>
    public byte sampleInterval
    {
        get
        {
            return sampleIntervalField;
        }
        set
        {
            sampleIntervalField = value;
        }
    }

    /// <remarks/>
    public decimal tempAir
    {
        get
        {
            return tempAirField;
        }
        set
        {
            tempAirField = value;
        }
    }

    /// <remarks/>
    public decimal tempHigh
    {
        get
        {
            return tempHighField;
        }
        set
        {
            tempHighField = value;
        }
    }

    /// <remarks/>
    public decimal tempLow
    {
        get
        {
            return tempLowField;
        }
        set
        {
            tempLowField = value;
        }
    }

    /// <remarks/>
    public object visibility
    {
        get
        {
            return visibilityField;
        }
        set
        {
            visibilityField = value;
        }
    }

    /// <remarks/>
    public object weather
    {
        get
        {
            return weatherField;
        }
        set
        {
            weatherField = value;
        }
    }

    /// <remarks/>
    public object weight
    {
        get
        {
            return weightField;
        }
        set
        {
            weightField = value;
        }
    }

    /// <remarks/>
    public string notes
    {
        get
        {
            return notesField;
        }
        set
        {
            notesField = value;
        }
    }

    /// <remarks/>
    public object diveMaster
    {
        get
        {
            return diveMasterField;
        }
        set
        {
            diveMasterField = value;
        }
    }

    /// <remarks/>
    public object diveOperator
    {
        get
        {
            return diveOperatorField;
        }
        set
        {
            diveOperatorField = value;
        }
    }

    /// <remarks/>
    public object skipper
    {
        get
        {
            return skipperField;
        }
        set
        {
            skipperField = value;
        }
    }

    /// <remarks/>
    public object boat
    {
        get
        {
            return boatField;
        }
        set
        {
            boatField = value;
        }
    }

    /// <remarks/>
    public object tags
    {
        get
        {
            return tagsField;
        }
        set
        {
            tagsField = value;
        }
    }

    /// <remarks/>
    public object types
    {
        get
        {
            return typesField;
        }
        set
        {
            typesField = value;
        }
    }

    /// <remarks/>
    public object buddies
    {
        get
        {
            return buddiesField;
        }
        set
        {
            buddiesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable = false)]
    public divesDiveItem[] gear
    {
        get
        {
            return gearField;
        }
        set
        {
            gearField = value;
        }
    }

    /// <remarks/>
    public divesDiveGases gases
    {
        get
        {
            return gasesField;
        }
        set
        {
            gasesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("sample", IsNullable = false)]
    public divesDiveSample[] samples
    {
        get
        {
            return samplesField;
        }
        set
        {
            samplesField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class divesDiveItem
{

    private string typeField;

    private string manufacturerField;

    private string nameField;

    private string serialField;

    /// <remarks/>
    public string type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }

    /// <remarks/>
    public string manufacturer
    {
        get
        {
            return manufacturerField;
        }
        set
        {
            manufacturerField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return nameField;
        }
        set
        {
            nameField = value;
        }
    }

    /// <remarks/>
    public string serial
    {
        get
        {
            return serialField;
        }
        set
        {
            serialField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class divesDiveGases
{

    private divesDiveGasesGas gasField;

    /// <remarks/>
    public divesDiveGasesGas gas
    {
        get
        {
            return gasField;
        }
        set
        {
            gasField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class divesDiveGasesGas
{

    private decimal pressureStartField;

    private decimal pressureEndField;

    private byte oxygenField;

    private byte heliumField;

    private byte doubleField;

    private byte tankSizeField;

    private ushort workingPressureField;

    private string supplyTypeField;

    private ushort durationField;

    private string tankNameField;

    /// <remarks/>
    public decimal pressureStart
    {
        get
        {
            return pressureStartField;
        }
        set
        {
            pressureStartField = value;
        }
    }

    /// <remarks/>
    public decimal pressureEnd
    {
        get
        {
            return pressureEndField;
        }
        set
        {
            pressureEndField = value;
        }
    }

    /// <remarks/>
    public byte oxygen
    {
        get
        {
            return oxygenField;
        }
        set
        {
            oxygenField = value;
        }
    }

    /// <remarks/>
    public byte helium
    {
        get
        {
            return heliumField;
        }
        set
        {
            heliumField = value;
        }
    }

    /// <remarks/>
    public byte @double
    {
        get
        {
            return doubleField;
        }
        set
        {
            doubleField = value;
        }
    }

    /// <remarks/>
    public byte tankSize
    {
        get
        {
            return tankSizeField;
        }
        set
        {
            tankSizeField = value;
        }
    }

    /// <remarks/>
    public ushort workingPressure
    {
        get
        {
            return workingPressureField;
        }
        set
        {
            workingPressureField = value;
        }
    }

    /// <remarks/>
    public string supplyType
    {
        get
        {
            return supplyTypeField;
        }
        set
        {
            supplyTypeField = value;
        }
    }

    /// <remarks/>
    public ushort duration
    {
        get
        {
            return durationField;
        }
        set
        {
            durationField = value;
        }
    }

    /// <remarks/>
    public string tankName
    {
        get
        {
            return tankNameField;
        }
        set
        {
            tankNameField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class divesDiveSample
{

    private ushort timeField;

    private decimal depthField;

    private decimal pressureField;

    private string alarmField;

    private object extraField;

    private decimal temperatureField;

    private decimal ppo2Field;

    private byte ndtField;

    /// <remarks/>
    public ushort time
    {
        get
        {
            return timeField;
        }
        set
        {
            timeField = value;
        }
    }

    /// <remarks/>
    public decimal depth
    {
        get
        {
            return depthField;
        }
        set
        {
            depthField = value;
        }
    }

    /// <remarks/>
    public decimal pressure
    {
        get
        {
            return pressureField;
        }
        set
        {
            pressureField = value;
        }
    }

    /// <remarks/>
    public string alarm
    {
        get
        {
            return alarmField;
        }
        set
        {
            alarmField = value;
        }
    }

    /// <remarks/>
    public object extra
    {
        get
        {
            return extraField;
        }
        set
        {
            extraField = value;
        }
    }

    /// <remarks/>
    public decimal temperature
    {
        get
        {
            return temperatureField;
        }
        set
        {
            temperatureField = value;
        }
    }

    /// <remarks/>
    public decimal ppo2
    {
        get
        {
            return ppo2Field;
        }
        set
        {
            ppo2Field = value;
        }
    }

    /// <remarks/>
    public byte ndt
    {
        get
        {
            return ndtField;
        }
        set
        {
            ndtField = value;
        }
    }
    public override string ToString()
    {
        return string.Format("Time: {0} Depth: {1} Pressure: {2} Temperature: {3} Alarm: {4}", time, depth, pressure, temperature, alarm);
    }
}

