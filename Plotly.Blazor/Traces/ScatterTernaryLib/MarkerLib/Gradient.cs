/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces.ScatterTernaryLib.MarkerLib
{
    /// <summary>
    ///     The Gradient class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    public class Gradient 
    {
        /// <summary>
        ///     Sets the type of gradient used to fill the markers
        /// </summary>
        [JsonPropertyName(@"type")]
        public Plotly.Blazor.Traces.ScatterTernaryLib.MarkerLib.GradientLib.TypeEnum? Type { get; set;} 

        /// <summary>
        ///     Sets the type of gradient used to fill the markers
        /// </summary>
        [JsonPropertyName(@"type")]
        [Array]
        public IList<Plotly.Blazor.Traces.ScatterTernaryLib.MarkerLib.GradientLib.TypeEnum?> TypeArray { get; set;} 

        /// <summary>
        ///     Sets the final color of the gradient fill: the center color for radial,
        ///     the right for horizontal, or the bottom for vertical.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the final color of the gradient fill: the center color for radial,
        ///     the right for horizontal, or the bottom for vertical.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public IList<object> ColorArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  type .
        /// </summary>
        [JsonPropertyName(@"typesrc")]
        public string TypeSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set;} 

    }
}