/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The ScatterGl class.
    ///     Implements the <see cref="ITrace" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    public class ScatterGl : ITrace
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.ScatterGl;

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public Plotly.Blazor.Traces.ScatterGlLib.VisibleEnum? Visible { get; set;} 

        /// <summary>
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set;} 

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
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public Plotly.Blazor.Traces.ScatterGlLib.HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        [Array]
        public IList<Plotly.Blazor.Traces.ScatterGlLib.HoverInfoFlag?> HoverInfoArray { get; set;} 

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Plotly.Blazor.Traces.ScatterGlLib.HoverLabel HoverLabel { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Plotly.Blazor.Traces.ScatterGlLib.Stream Stream { get; set;} 

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
        ///     Sets the x coordinates.
        /// </summary>
        [JsonPropertyName(@"x")]
        public IList<object> X { get; set;} 

        /// <summary>
        ///     Alternate to <c>x</c>. Builds a linear space of x coordinates. Use with
        ///     <c>dx</c> where <c>x0</c> is the starting coordinate and <c>dx</c> the step.
        /// </summary>
        [JsonPropertyName(@"x0")]
        public object X0 { get; set;} 

        /// <summary>
        ///     Sets the x coordinate step. See <c>x0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"dx")]
        public float? DX { get; set;} 

        /// <summary>
        ///     Sets the y coordinates.
        /// </summary>
        [JsonPropertyName(@"y")]
        public IList<object> Y { get; set;} 

        /// <summary>
        ///     Alternate to <c>y</c>. Builds a linear space of y coordinates. Use with
        ///     <c>dy</c> where <c>y0</c> is the starting coordinate and <c>dy</c> the step.
        /// </summary>
        [JsonPropertyName(@"y0")]
        public object Y0 { get; set;} 

        /// <summary>
        ///     Sets the y coordinate step. See <c>y0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"dy")]
        public float? Dy { get; set;} 

        /// <summary>
        ///     Sets text elements associated with each (x,y) pair. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     If trace <c>hoverinfo</c> contains a <c>text</c> flag and <c>hovertext</c>
        ///     is not set, these elements will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets text elements associated with each (x,y) pair. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     If trace <c>hoverinfo</c> contains a <c>text</c> flag and <c>hovertext</c>
        ///     is not set, these elements will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        [Array]
        public IList<string> TextArray { get; set;} 

        /// <summary>
        ///     Sets hover text elements associated with each (x,y) pair. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     To be seen, trace <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string HoverText { get; set;} 

        /// <summary>
        ///     Sets hover text elements associated with each (x,y) pair. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     To be seen, trace <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        [Array]
        public IList<string> HoverTextArray { get; set;} 

        /// <summary>
        ///     Sets the positions of the <c>text</c> elements with respects to the (x,y)
        ///     coordinates.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        public Plotly.Blazor.Traces.ScatterGlLib.TextPositionEnum? TextPosition { get; set;} 

        /// <summary>
        ///     Sets the positions of the <c>text</c> elements with respects to the (x,y)
        ///     coordinates.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        [Array]
        public IList<Plotly.Blazor.Traces.ScatterGlLib.TextPositionEnum?> TextPositionArray { get; set;} 

        /// <summary>
        ///     Sets the text font.
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public Plotly.Blazor.Traces.ScatterGlLib.TextFont TextFont { get; set;} 

        /// <summary>
        ///     Determines the drawing mode for this scatter trace.
        /// </summary>
        [JsonPropertyName(@"mode")]
        public Plotly.Blazor.Traces.ScatterGlLib.ModeFlag? Mode { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.ScatterGlLib.Line Line { get; set;} 

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Plotly.Blazor.Traces.ScatterGlLib.Marker Marker { get; set;} 

        /// <summary>
        ///     Determines whether or not gaps (i.e. {nan} or missing values) in the provided
        ///     data arrays are connected.
        /// </summary>
        [JsonPropertyName(@"connectgaps")]
        public bool? ConnectGaps { get; set;} 

        /// <summary>
        ///     Sets the area to fill with a solid color. Defaults to <c>none</c> unless
        ///     this trace is stacked, then it gets <c>tonexty</c> (<c>tonextx</c>) if <c>orientation</c>
        ///     is <c>v</c> (<c>h</c>) Use with <c>fillcolor</c> if not <c>none</c>. <c>tozerox</c>
        ///     and <c>tozeroy</c> fill to x=0 and y=0 respectively. <c>tonextx</c> and
        ///     <c>tonexty</c> fill between the endpoints of this trace and the endpoints
        ///     of the trace before it, connecting those endpoints with straight lines (to
        ///     make a stacked area graph); if there is no trace before it, they behave
        ///     like <c>tozerox</c> and <c>tozeroy</c>. <c>toself</c> connects the endpoints
        ///     of the trace (or each segment of the trace if it has gaps) into a closed
        ///     shape. <c>tonext</c> fills the space between two traces if one completely
        ///     encloses the other (eg consecutive contour lines), and behaves like <c>toself</c>
        ///     if there is no trace before it. <c>tonext</c> should not be used if one
        ///     trace does not enclose the other. Traces in a <c>stackgroup</c> will only
        ///     fill to (or be filled to) other traces in the same group. With multiple
        ///     <c>stackgroup</c>s or some traces stacked and some not, if fill-linked traces
        ///     are not already consecutive, the later ones will be pushed down in the drawing
        ///     order.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public Plotly.Blazor.Traces.ScatterGlLib.FillEnum? Fill { get; set;} 

        /// <summary>
        ///     Sets the fill color. Defaults to a half-transparent variant of the line
        ///     color, marker color, or marker line color, whichever is available.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set;} 

        /// <summary>
        ///     Gets or sets the Selected.
        /// </summary>
        [JsonPropertyName(@"selected")]
        public Plotly.Blazor.Traces.ScatterGlLib.Selected Selected { get; set;} 

        /// <summary>
        ///     Gets or sets the Unselected.
        /// </summary>
        [JsonPropertyName(@"unselected")]
        public Plotly.Blazor.Traces.ScatterGlLib.Unselected Unselected { get; set;} 

        /// <summary>
        ///     Sets the opacity of the trace.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

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
        ///     that are &#39;arrayOk: true&#39;) are available.  Anything contained in
        ///     tag <c>&lt;extra&gt;</c> is displayed in the secondary box, for example
        ///     <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide the secondary
        ///     box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
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
        ///     that are &#39;arrayOk: true&#39;) are available.  Anything contained in
        ///     tag <c>&lt;extra&gt;</c> is displayed in the secondary box, for example
        ///     <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide the secondary
        ///     box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public IList<string> HoverTemplateArray { get; set;} 

        /// <summary>
        ///     Template string used for rendering the information text that appear on points.
        ///     Note that this will override <c>textinfo</c>. Variables are inserted using
        ///     %{variable}, for example &quot;y: %{y}&quot;. Numbers are formatted using
        ///     d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price: %{y:$.2f}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. Every attributes that can be
        ///     specified per-point (the ones that are &#39;arrayOk: true&#39;) are available.
        /// </summary>
        [JsonPropertyName(@"texttemplate")]
        public string TextTemplate { get; set;} 

        /// <summary>
        ///     Template string used for rendering the information text that appear on points.
        ///     Note that this will override <c>textinfo</c>. Variables are inserted using
        ///     %{variable}, for example &quot;y: %{y}&quot;. Numbers are formatted using
        ///     d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price: %{y:$.2f}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. Every attributes that can be
        ///     specified per-point (the ones that are &#39;arrayOk: true&#39;) are available.
        /// </summary>
        [JsonPropertyName(@"texttemplate")]
        [Array]
        public IList<string> TextTemplateArray { get; set;} 

        /// <summary>
        ///     Gets or sets the ErrorX.
        /// </summary>
        [JsonPropertyName(@"error_x")]
        public Plotly.Blazor.Traces.ScatterGlLib.ErrorX ErrorX { get; set;} 

        /// <summary>
        ///     Gets or sets the ErrorY.
        /// </summary>
        [JsonPropertyName(@"error_y")]
        public Plotly.Blazor.Traces.ScatterGlLib.ErrorY ErrorY { get; set;} 

        /// <summary>
        ///     Sets the calendar system to use with <c>x</c> date data.
        /// </summary>
        [JsonPropertyName(@"xcalendar")]
        public Plotly.Blazor.Traces.ScatterGlLib.XCalendarEnum? XCalendar { get; set;} 

        /// <summary>
        ///     Sets the calendar system to use with <c>y</c> date data.
        /// </summary>
        [JsonPropertyName(@"ycalendar")]
        public Plotly.Blazor.Traces.ScatterGlLib.YCalendarEnum? YCalendar { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace&#39;s x coordinates and a 2D cartesian
        ///     x axis. If <c>x</c> (the default value), the x coordinates refer to <c>layout.xaxis</c>.
        ///     If <c>x2</c>, the x coordinates refer to <c>layout.xaxis2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"xaxis")]
        public string XAxis { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace&#39;s y coordinates and a 2D cartesian
        ///     y axis. If <c>y</c> (the default value), the y coordinates refer to <c>layout.yaxis</c>.
        ///     If <c>y2</c>, the y coordinates refer to <c>layout.yaxis2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"yaxis")]
        public string YAxis { get; set;} 

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
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string XSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  y .
        /// </summary>
        [JsonPropertyName(@"ysrc")]
        public string YSrc { get; set;} 

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
        ///     Sets the source reference on Chart Studio Cloud for  textposition .
        /// </summary>
        [JsonPropertyName(@"textpositionsrc")]
        public string TextPositionSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  texttemplate .
        /// </summary>
        [JsonPropertyName(@"texttemplatesrc")]
        public string TextTemplateSrc { get; set;} 

    }
}