/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces.ScatterTernaryLib.MarkerLib
{
    /// <summary>
    ///     The Line class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    public class Line 
    {
        /// <summary>
        ///     Sets the width (in px) of the lines bounding the marker points.
        /// </summary>
        [JsonPropertyName(@"width")]
        public float? Width { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the lines bounding the marker points.
        /// </summary>
        [JsonPropertyName(@"width")]
        [Array]
        public IList<float?> WidthArray { get; set;} 

        /// <summary>
        ///     Sets themarker.linecolor. It accepts either a specific color or an array
        ///     of numbers that are mapped to the colorscale relative to the max and min
        ///     values of the array or relative to <c>marker.line.cmin</c> and <c>marker.line.cmax</c>
        ///     if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets themarker.linecolor. It accepts either a specific color or an array
        ///     of numbers that are mapped to the colorscale relative to the max and min
        ///     values of the array or relative to <c>marker.line.cmin</c> and <c>marker.line.cmax</c>
        ///     if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public IList<object> ColorArray { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in <c>marker.line.color</c>) or the bounds set in <c>marker.line.cmin</c>
        ///     and <c>marker.line.cmax</c>  Has an effect only if in <c>marker.line.color</c>is
        ///     set to a numerical array. Defaults to <c>false</c> when <c>marker.line.cmin</c>
        ///     and <c>marker.line.cmax</c> are set by the user.
        /// </summary>
        [JsonPropertyName(@"cauto")]
        public bool? CAuto { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Has an effect only if in <c>marker.line.color</c>is
        ///     set to a numerical array. Value should have the same units as in <c>marker.line.color</c>
        ///     and if set, <c>marker.line.cmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public float? CMin { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Has an effect only if in <c>marker.line.color</c>is
        ///     set to a numerical array. Value should have the same units as in <c>marker.line.color</c>
        ///     and if set, <c>marker.line.cmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public float? CMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>marker.line.cmin</c>
        ///     and/or <c>marker.line.cmax</c> to be equidistant to this point. Has an effect
        ///     only if in <c>marker.line.color</c>is set to a numerical array. Value should
        ///     have the same units as in <c>marker.line.color</c>. Has no effect when <c>marker.line.cauto</c>
        ///     is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"cmid")]
        public float? CMid { get; set;} 

        /// <summary>
        ///     Sets the colorscale. Has an effect only if in <c>marker.line.color</c>is
        ///     set to a numerical array. The colorscale must be an array containing arrays
        ///     mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color
        ///     string. At minimum, a mapping for the lowest (0) and highest (1) values
        ///     are required. For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>marker.line.cmin</c>
        ///     and <c>marker.line.cmax</c>. Alternatively, <c>colorscale</c> may be a palette
        ///     name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>marker.line.colorscale</c>. Has
        ///     an effect only if in <c>marker.line.color</c>is set to a numerical array.
        ///     In case <c>colorscale</c> is unspecified or <c>autocolorscale</c> is true,
        ///     the default  palette will be chosen according to whether numbers in the
        ///     <c>color</c> array are all positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. Has an effect only if in <c>marker.line.color</c>is
        ///     set to a numerical array. If true, <c>marker.line.cmin</c> will correspond
        ///     to the last color in the array and <c>marker.line.cmax</c> will correspond
        ///     to the first color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are <c>coloraxis</c>, <c>coloraxis2</c>, <c>coloraxis3</c>, etc. Settings
        ///     for these shared color axes are set in the layout, under <c>layout.coloraxis</c>,
        ///     <c>layout.coloraxis2</c>, etc. Note that multiple color scales can be linked
        ///     to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string ColorAxis { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  width .
        /// </summary>
        [JsonPropertyName(@"widthsrc")]
        public string WidthSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set;} 

    }
}