﻿namespace Tagging.Helpers
{
    public interface ISensorsConversionHelper
    {
        long ConvertTextBoxTimeToUnixTimestamp(string time);
        string ConvertTimestampToTextTimeFormat(long timestamp);
    }
}