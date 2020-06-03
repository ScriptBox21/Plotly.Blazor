/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The ChoroplethMapBox class.
    ///     Implements the <see cref="ITrace" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    public class ChoroplethMapBox : ITrace
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.ChoroplethMapBox;

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public Plotly.Blazor.Traces.ChoroplethMapBoxLib.VisibleEnum? Visible { get; set;} 

        /// <summary>
        ///     Sets the legend group for this trace. Traces part of the same legend group
        ///     hide/show at the same time when toggling legend items.
        /// </summary>
        [JsonPropertyName(@"legendgroup")]
        public string LegendGroup { get; set;} 

        /// <summary>
        ///     Sets the trace name. The trace name appear as the legend item and on hover.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Assign an id to this trace, Use this to provide object constancy between
        ///     traces during animations and transitions.
        /// </summary>
        [JsonPropertyName(@"uid")]
        public string UId { get; set;} 

        /// <summary>
        ///     Assigns id labels to each datum. These ids for object constancy of data
        ///     points during animation. Should be an array of strings, not numbers or any
        ///     other type.
        /// </summary>
        [JsonPropertyName(@"ids")]
        public IList<object> Ids { get; set;} 

        /// <summary>
        ///     Assigns extra data each datum. This may be useful when listening to hover,
        ///     click and selection events. Note that, <c>scatter</c> traces also appends
        ///     customdata items in the markers DOM elements
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public IList<object> CustomData { get; set;} 

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace <c>name</c>, graph,
        ///     axis and colorbar <c>title.text</c>, annotation <c>text</c> <c>rangeselector</c>,
        ///     <c>updatemenues</c> and <c>sliders</c> <c>label</c> text all support <c>meta</c>.
        ///     To access the trace <c>meta</c> values in an attribute in the same trace,
        ///     simply use <c>%{meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     item in question. To access trace <c>meta</c> in layout attributes, use
        ///     <c>%{data[n[.meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     and <c>n</c> is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        public object Meta { get; set;} 

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace <c>name</c>, graph,
        ///     axis and colorbar <c>title.text</c>, annotation <c>text</c> <c>rangeselector</c>,
        ///     <c>updatemenues</c> and <c>sliders</c> <c>label</c> text all support <c>meta</c>.
        ///     To access the trace <c>meta</c> values in an attribute in the same trace,
        ///     simply use <c>%{meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     item in question. To access trace <c>meta</c> in layout attributes, use
        ///     <c>%{data[n[.meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     and <c>n</c> is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        [Array]
        public IList<object> MetaArray { get; set;} 

        /// <summary>
        ///     Array containing integer indices of selected points. Has an effect only
        ///     for traces that support selections. Note that an empty array means an empty
        ///     selection where the <c>unselected</c> are turned on for all points, whereas,
        ///     any other non-array values means no selection all where the <c>selected</c>
        ///     and <c>unselected</c> styles have no effect.
        /// </summary>
        [JsonPropertyName(@"selectedpoints")]
        public object SelectedPoints { get; set;} 

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Plotly.Blazor.Traces.ChoroplethMapBoxLib.HoverLabel HoverLabel { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Plotly.Blazor.Traces.ChoroplethMapBoxLib.Stream Stream { get; set;} 

        /// <summary>
        ///     Gets or sets the Transforms.
        /// </summary>
        [JsonPropertyName(@"transforms")]
        public IList<ITransform> Transforms { get; set;} 

        /// <summary>
        ///     Controls persistence of some user-driven changes to the trace: <c>constraintrange</c>
        ///     in <c>parcoords</c> traces, as well as some &#39;editable: true&#39; modifications
        ///     such as <c>name</c> and <c>colorbar.title</c>. Defaults to <c>layout.uirevision</c>.
        ///     Note that other user-driven trace attribute changes are controlled by <c>layout</c>
        ///     attributes: <c>trace.visible</c> is controlled by <c>layout.legend.uirevision</c>,
        ///     <c>selectedpoints</c> is controlled by <c>layout.selectionrevision</c>,
        ///     and <c>colorbar.(x|y)</c> (accessible with &#39;config: {editable: true}&#39;)
        ///     is controlled by <c>layout.editrevision</c>. Trace changes are tracked by
        ///     <c>uid</c>, which only falls back on trace index if no <c>uid</c> is provided.
        ///     So if your app can add/remove traces before the end of the <c>data</c> array,
        ///     such that the same trace has a different index, you can still preserve user-driven
        ///     changes if you give each trace a <c>uid</c> that stays with it as it moves.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <summary>
        ///     Sets which features found in <c>geojson</c> to plot using their feature
        ///     <c>id</c> field.
        /// </summary>
        [JsonPropertyName(@"locations")]
        public IList<object> Locations { get; set;} 

        /// <summary>
        ///     Sets the color values.
        /// </summary>
        [JsonPropertyName(@"z")]
        public IList<object> Z { get; set;} 

        /// <summary>
        ///     Sets the GeoJSON data associated with this trace. It can be set as a valid
        ///     GeoJSON object or as a URL string. Note that we only accept GeoJSONs of
        ///     type <c>FeatureCollection</c> or <c>Feature</c> with geometries of type
        ///     <c>Polygon</c> or <c>MultiPolygon</c>.
        /// </summary>
        [JsonPropertyName(@"geojson")]
        public object GeoJson { get; set;} 

        /// <summary>
        ///     Sets the key in GeoJSON features which is used as id to match the items
        ///     included in the <c>locations</c> array. Support nested property, for example
        ///     <c>properties.name</c>.
        /// </summary>
        [JsonPropertyName(@"featureidkey")]
        public string FeatureIdKey { get; set;} 

        /// <summary>
        ///     Determines if the choropleth polygons will be inserted before the layer
        ///     with the specified ID. By default, choroplethmapbox traces are placed above
        ///     the water layers. If set to &#39;&#39;, the layer will be inserted above
        ///     every existing layer.
        /// </summary>
        [JsonPropertyName(@"below")]
        public string Below { get; set;} 

        /// <summary>
        ///     Sets the text elements associated with each location.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets the text elements associated with each location.
        /// </summary>
        [JsonPropertyName(@"text")]
        [Array]
        public IList<string> TextArray { get; set;} 

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string HoverText { get; set;} 

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        [Array]
        public IList<string> HoverTextArray { get; set;} 

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Plotly.Blazor.Traces.ChoroplethMapBoxLib.Marker Marker { get; set;} 

        /// <summary>
        ///     Gets or sets the Selected.
        /// </summary>
        [JsonPropertyName(@"selected")]
        public Plotly.Blazor.Traces.ChoroplethMapBoxLib.Selected Selected { get; set;} 

        /// <summary>
        ///     Gets or sets the Unselected.
        /// </summary>
        [JsonPropertyName(@"unselected")]
        public Plotly.Blazor.Traces.ChoroplethMapBoxLib.Unselected Unselected { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public Plotly.Blazor.Traces.ChoroplethMapBoxLib.HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        [Array]
        public IList<Plotly.Blazor.Traces.ChoroplethMapBoxLib.HoverInfoFlag?> HoverInfoArray { get; set;} 

        /// <summary>
        ///     Template string used for rendering the information that appear on hover
        ///     box. Note that this will override <c>hoverinfo</c>. Variables are inserted
        ///     using %{variable}, for example &quot;y: %{y}&quot;. Numbers are formatted
        ///     using d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price:
        ///     %{y:$.2f}&quot;. https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. The variables available in <c>hovertemplate</c>
        ///     are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data.
        ///     Additionally, every attributes that can be specified per-point (the ones
        ///     that are &#39;arrayOk: true&#39;) are available. variable <c>properties</c>
        ///     Anything contained in tag <c>&lt;extra&gt;</c> is displayed in the secondary
        ///     box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide
        ///     the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string HoverTemplate { get; set;} 

        /// <summary>
        ///     Template string used for rendering the information that appear on hover
        ///     box. Note that this will override <c>hoverinfo</c>. Variables are inserted
        ///     using %{variable}, for example &quot;y: %{y}&quot;. Numbers are formatted
        ///     using d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price:
        ///     %{y:$.2f}&quot;. https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. The variables available in <c>hovertemplate</c>
        ///     are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data.
        ///     Additionally, every attributes that can be specified per-point (the ones
        ///     that are &#39;arrayOk: true&#39;) are available. variable <c>properties</c>
        ///     Anything contained in tag <c>&lt;extra&gt;</c> is displayed in the secondary
        ///     box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide
        ///     the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public IList<string> HoverTemplateArray { get; set;} 

        /// <summary>
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in <c>z</c>) or the bounds set in <c>zmin</c> and <c>zmax</c>
        ///      Defaults to <c>false</c> when <c>zmin</c> and <c>zmax</c> are set by the
        ///     user.
        /// </summary>
        [JsonPropertyName(@"zauto")]
        public bool? ZAuto { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Value should have the same units
        ///     as in <c>z</c> and if set, <c>zmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmin")]
        public float? ZMin { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Value should have the same units
        ///     as in <c>z</c> and if set, <c>zmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmax")]
        public float? ZMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>zmin</c> and/or <c>zmax</c>
        ///     to be equidistant to this point. Value should have the same units as in
        ///     <c>z</c>. Has no effect when <c>zauto</c> is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"zmid")]
        public float? ZMid { get; set;} 

        /// <summary>
        ///     Sets the colorscale. The colorscale must be an array containing arrays mapping
        ///     a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string.
        ///     At minimum, a mapping for the lowest (0) and highest (1) values are required.
        ///     For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>zmin</c> and
        ///     <c>zmax</c>. Alternatively, <c>colorscale</c> may be a palette name string
        ///     of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>colorscale</c>. In case <c>colorscale</c>
        ///     is unspecified or <c>autocolorscale</c> is true, the default  palette will
        ///     be chosen according to whether numbers in the <c>color</c> array are all
        ///     positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. If true, <c>zmin</c> will correspond
        ///     to the last color in the array and <c>zmax</c> will correspond to the first
        ///     color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set;} 

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public Plotly.Blazor.Traces.ChoroplethMapBoxLib.ColorBar ColorBar { get; set;} 

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
        ///     Sets a reference between this trace&#39;s data coordinates and a mapbox
        ///     subplot. If <c>mapbox</c> (the default value), the data refer to <c>layout.mapbox</c>.
        ///     If <c>mapbox2</c>, the data refer to <c>layout.mapbox2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"subplot")]
        public string Subplot { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ids .
        /// </summary>
        [JsonPropertyName(@"idssrc")]
        public string IdsSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  customdata .
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string CustomDataSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  meta .
        /// </summary>
        [JsonPropertyName(@"metasrc")]
        public string MetaSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  locations .
        /// </summary>
        [JsonPropertyName(@"locationssrc")]
        public string LocationsSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  z .
        /// </summary>
        [JsonPropertyName(@"zsrc")]
        public string ZSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertext .
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string HoverTextSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set;} 

    }
}