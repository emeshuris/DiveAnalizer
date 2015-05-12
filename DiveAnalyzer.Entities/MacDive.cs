
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
            return this.unitsField;
        }
        set
        {
            this.unitsField = value;
        }
    }

    /// <remarks/>
    public string schema
    {
        get
        {
            return this.schemaField;
        }
        set
        {
            this.schemaField = value;
        }
    }

    /// <remarks/>
    public divesDive dive
    {
        get
        {
            return this.diveField;
        }
        set
        {
            this.diveField = value;
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
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    public string identifier
    {
        get
        {
            return this.identifierField;
        }
        set
        {
            this.identifierField = value;
        }
    }

    /// <remarks/>
    public byte diveNumber
    {
        get
        {
            return this.diveNumberField;
        }
        set
        {
            this.diveNumberField = value;
        }
    }

    /// <remarks/>
    public byte rating
    {
        get
        {
            return this.ratingField;
        }
        set
        {
            this.ratingField = value;
        }
    }

    /// <remarks/>
    public string country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    /// <remarks/>
    public string location
    {
        get
        {
            return this.locationField;
        }
        set
        {
            this.locationField = value;
        }
    }

    /// <remarks/>
    public string site
    {
        get
        {
            return this.siteField;
        }
        set
        {
            this.siteField = value;
        }
    }

    /// <remarks/>
    public byte repetitiveDive
    {
        get
        {
            return this.repetitiveDiveField;
        }
        set
        {
            this.repetitiveDiveField = value;
        }
    }

    /// <remarks/>
    public decimal siteLat
    {
        get
        {
            return this.siteLatField;
        }
        set
        {
            this.siteLatField = value;
        }
    }

    /// <remarks/>
    public decimal siteLon
    {
        get
        {
            return this.siteLonField;
        }
        set
        {
            this.siteLonField = value;
        }
    }

    /// <remarks/>
    public string diver
    {
        get
        {
            return this.diverField;
        }
        set
        {
            this.diverField = value;
        }
    }

    /// <remarks/>
    public string computer
    {
        get
        {
            return this.computerField;
        }
        set
        {
            this.computerField = value;
        }
    }

    /// <remarks/>
    public uint serial
    {
        get
        {
            return this.serialField;
        }
        set
        {
            this.serialField = value;
        }
    }

    /// <remarks/>
    public decimal maxDepth
    {
        get
        {
            return this.maxDepthField;
        }
        set
        {
            this.maxDepthField = value;
        }
    }

    /// <remarks/>
    public decimal averageDepth
    {
        get
        {
            return this.averageDepthField;
        }
        set
        {
            this.averageDepthField = value;
        }
    }

    /// <remarks/>
    public decimal cns
    {
        get
        {
            return this.cnsField;
        }
        set
        {
            this.cnsField = value;
        }
    }

    /// <remarks/>
    public string decoModel
    {
        get
        {
            return this.decoModelField;
        }
        set
        {
            this.decoModelField = value;
        }
    }

    /// <remarks/>
    public ushort duration
    {
        get
        {
            return this.durationField;
        }
        set
        {
            this.durationField = value;
        }
    }

    /// <remarks/>
    public string gasModel
    {
        get
        {
            return this.gasModelField;
        }
        set
        {
            this.gasModelField = value;
        }
    }

    /// <remarks/>
    public byte surfaceInterval
    {
        get
        {
            return this.surfaceIntervalField;
        }
        set
        {
            this.surfaceIntervalField = value;
        }
    }

    /// <remarks/>
    public byte sampleInterval
    {
        get
        {
            return this.sampleIntervalField;
        }
        set
        {
            this.sampleIntervalField = value;
        }
    }

    /// <remarks/>
    public decimal tempAir
    {
        get
        {
            return this.tempAirField;
        }
        set
        {
            this.tempAirField = value;
        }
    }

    /// <remarks/>
    public decimal tempHigh
    {
        get
        {
            return this.tempHighField;
        }
        set
        {
            this.tempHighField = value;
        }
    }

    /// <remarks/>
    public decimal tempLow
    {
        get
        {
            return this.tempLowField;
        }
        set
        {
            this.tempLowField = value;
        }
    }

    /// <remarks/>
    public object visibility
    {
        get
        {
            return this.visibilityField;
        }
        set
        {
            this.visibilityField = value;
        }
    }

    /// <remarks/>
    public object weather
    {
        get
        {
            return this.weatherField;
        }
        set
        {
            this.weatherField = value;
        }
    }

    /// <remarks/>
    public object weight
    {
        get
        {
            return this.weightField;
        }
        set
        {
            this.weightField = value;
        }
    }

    /// <remarks/>
    public string notes
    {
        get
        {
            return this.notesField;
        }
        set
        {
            this.notesField = value;
        }
    }

    /// <remarks/>
    public object diveMaster
    {
        get
        {
            return this.diveMasterField;
        }
        set
        {
            this.diveMasterField = value;
        }
    }

    /// <remarks/>
    public object diveOperator
    {
        get
        {
            return this.diveOperatorField;
        }
        set
        {
            this.diveOperatorField = value;
        }
    }

    /// <remarks/>
    public object skipper
    {
        get
        {
            return this.skipperField;
        }
        set
        {
            this.skipperField = value;
        }
    }

    /// <remarks/>
    public object boat
    {
        get
        {
            return this.boatField;
        }
        set
        {
            this.boatField = value;
        }
    }

    /// <remarks/>
    public object tags
    {
        get
        {
            return this.tagsField;
        }
        set
        {
            this.tagsField = value;
        }
    }

    /// <remarks/>
    public object types
    {
        get
        {
            return this.typesField;
        }
        set
        {
            this.typesField = value;
        }
    }

    /// <remarks/>
    public object buddies
    {
        get
        {
            return this.buddiesField;
        }
        set
        {
            this.buddiesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable = false)]
    public divesDiveItem[] gear
    {
        get
        {
            return this.gearField;
        }
        set
        {
            this.gearField = value;
        }
    }

    /// <remarks/>
    public divesDiveGases gases
    {
        get
        {
            return this.gasesField;
        }
        set
        {
            this.gasesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("sample", IsNullable = false)]
    public divesDiveSample[] samples
    {
        get
        {
            return this.samplesField;
        }
        set
        {
            this.samplesField = value;
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
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    public string manufacturer
    {
        get
        {
            return this.manufacturerField;
        }
        set
        {
            this.manufacturerField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string serial
    {
        get
        {
            return this.serialField;
        }
        set
        {
            this.serialField = value;
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
            return this.gasField;
        }
        set
        {
            this.gasField = value;
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
            return this.pressureStartField;
        }
        set
        {
            this.pressureStartField = value;
        }
    }

    /// <remarks/>
    public decimal pressureEnd
    {
        get
        {
            return this.pressureEndField;
        }
        set
        {
            this.pressureEndField = value;
        }
    }

    /// <remarks/>
    public byte oxygen
    {
        get
        {
            return this.oxygenField;
        }
        set
        {
            this.oxygenField = value;
        }
    }

    /// <remarks/>
    public byte helium
    {
        get
        {
            return this.heliumField;
        }
        set
        {
            this.heliumField = value;
        }
    }

    /// <remarks/>
    public byte @double
    {
        get
        {
            return this.doubleField;
        }
        set
        {
            this.doubleField = value;
        }
    }

    /// <remarks/>
    public byte tankSize
    {
        get
        {
            return this.tankSizeField;
        }
        set
        {
            this.tankSizeField = value;
        }
    }

    /// <remarks/>
    public ushort workingPressure
    {
        get
        {
            return this.workingPressureField;
        }
        set
        {
            this.workingPressureField = value;
        }
    }

    /// <remarks/>
    public string supplyType
    {
        get
        {
            return this.supplyTypeField;
        }
        set
        {
            this.supplyTypeField = value;
        }
    }

    /// <remarks/>
    public ushort duration
    {
        get
        {
            return this.durationField;
        }
        set
        {
            this.durationField = value;
        }
    }

    /// <remarks/>
    public string tankName
    {
        get
        {
            return this.tankNameField;
        }
        set
        {
            this.tankNameField = value;
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
            return this.timeField;
        }
        set
        {
            this.timeField = value;
        }
    }

    /// <remarks/>
    public decimal depth
    {
        get
        {
            return this.depthField;
        }
        set
        {
            this.depthField = value;
        }
    }

    /// <remarks/>
    public decimal pressure
    {
        get
        {
            return this.pressureField;
        }
        set
        {
            this.pressureField = value;
        }
    }

    /// <remarks/>
    public string alarm
    {
        get
        {
            return this.alarmField;
        }
        set
        {
            this.alarmField = value;
        }
    }

    /// <remarks/>
    public object extra
    {
        get
        {
            return this.extraField;
        }
        set
        {
            this.extraField = value;
        }
    }

    /// <remarks/>
    public decimal temperature
    {
        get
        {
            return this.temperatureField;
        }
        set
        {
            this.temperatureField = value;
        }
    }

    /// <remarks/>
    public decimal ppo2
    {
        get
        {
            return this.ppo2Field;
        }
        set
        {
            this.ppo2Field = value;
        }
    }

    /// <remarks/>
    public byte ndt
    {
        get
        {
            return this.ndtField;
        }
        set
        {
            this.ndtField = value;
        }
    }
    public override string ToString()
    {
        return string.Format("Time: {0} Depth: {1} Pressure: {2} Temperature: {3} Alarm: {4}", time, depth, pressure, temperature, alarm);
    }
}

