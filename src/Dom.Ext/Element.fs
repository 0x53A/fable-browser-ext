[<AutoOpen>]
module Browser.DomExtensions_Element

open Fable.Core
open Browser.Types

type Element with
    //[<Emit("$0.addEventListener('MSGestureChange',$1...)")>] member __.addEventListener_MSGestureChange(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureDoubleTap',$1...)")>] member __.addEventListener_MSGestureDoubleTap(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureEnd',$1...)")>] member __.addEventListener_MSGestureEnd(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureHold',$1...)")>] member __.addEventListener_MSGestureHold(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureStart',$1...)")>] member __.addEventListener_MSGestureStart(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureTap',$1...)")>] member __.addEventListener_MSGestureTap(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGotPointerCapture',$1...)")>] member __.addEventListener_MSGotPointerCapture(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSInertiaStart',$1...)")>] member __.addEventListener_MSInertiaStart(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSLostPointerCapture',$1...)")>] member __.addEventListener_MSLostPointerCapture(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerCancel',$1...)")>] member __.addEventListener_MSPointerCancel(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerDown',$1...)")>] member __.addEventListener_MSPointerDown(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerEnter',$1...)")>] member __.addEventListener_MSPointerEnter(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerLeave',$1...)")>] member __.addEventListener_MSPointerLeave(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerMove',$1...)")>] member __.addEventListener_MSPointerMove(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerOut',$1...)")>] member __.addEventListener_MSPointerOut(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerOver',$1...)")>] member __.addEventListener_MSPointerOver(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerUp',$1...)")>] member __.addEventListener_MSPointerUp(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('ariarequest',$1...)")>] member __.addEventListener_ariarequest(listener: (AriaRequestEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('command',$1...)")>] member __.addEventListener_command(listener: (CommandEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('gotpointercapture',$1...)")>] member __.addEventListener_gotpointercapture(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('lostpointercapture',$1...)")>] member __.addEventListener_lostpointercapture(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('touchcancel',$1...)")>] member __.addEventListener_touchcancel(listener: (TouchEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('touchend',$1...)")>] member __.addEventListener_touchend(listener: (TouchEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('touchmove',$1...)")>] member __.addEventListener_touchmove(listener: (TouchEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('touchstart',$1...)")>] member __.addEventListener_touchstart(listener: (TouchEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('webkitfullscreenchange',$1...)")>] member __.addEventListener_webkitfullscreenchange(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('webkitfullscreenerror',$1...)")>] member __.addEventListener_webkitfullscreenerror(listener: (Event -> 'Out), ?useCapture: bool) = jsNative


    [<Emit("$0.getElementsByTagName('a')")>] member __.getElementsByTagName_a() : NodeListOf<HTMLAnchorElement> = jsNative
    [<Emit("$0.getElementsByTagName('abbr')")>] member __.getElementsByTagName_abbr() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('acronym')")>] member __.getElementsByTagName_acronym() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('address')")>] member __.getElementsByTagName_address() : NodeListOf<HTMLBlockElement> = jsNative
    //[<Emit("$0.getElementsByTagName('applet')")>] member __.getElementsByTagName_applet() : NodeListOf<HTMLAppletElement> = jsNative
    [<Emit("$0.getElementsByTagName('area')")>] member __.getElementsByTagName_area() : NodeListOf<HTMLAreaElement> = jsNative
    [<Emit("$0.getElementsByTagName('article')")>] member __.getElementsByTagName_article() : NodeListOf<HTMLElement> = jsNative
    [<Emit("$0.getElementsByTagName('aside')")>] member __.getElementsByTagName_aside() : NodeListOf<HTMLElement> = jsNative
    [<Emit("$0.getElementsByTagName('audio')")>] member __.getElementsByTagName_audio() : NodeListOf<HTMLAudioElement> = jsNative
    [<Emit("$0.getElementsByTagName('b')")>] member __.getElementsByTagName_b() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('base')")>] member __.getElementsByTagName_base() : NodeListOf<HTMLBaseElement> = jsNative
    //[<Emit("$0.getElementsByTagName('basefont')")>] member __.getElementsByTagName_basefont() : NodeListOf<HTMLBaseFontElement> = jsNative
    [<Emit("$0.getElementsByTagName('bdo')")>] member __.getElementsByTagName_bdo() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('big')")>] member __.getElementsByTagName_big() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('blockquote')")>] member __.getElementsByTagName_blockquote() : NodeListOf<HTMLBlockElement> = jsNative
    [<Emit("$0.getElementsByTagName('body')")>] member __.getElementsByTagName_body() : NodeListOf<HTMLBodyElement> = jsNative
    [<Emit("$0.getElementsByTagName('br')")>] member __.getElementsByTagName_br() : NodeListOf<HTMLBRElement> = jsNative
    [<Emit("$0.getElementsByTagName('button')")>] member __.getElementsByTagName_button() : NodeListOf<HTMLButtonElement> = jsNative
    [<Emit("$0.getElementsByTagName('canvas')")>] member __.getElementsByTagName_canvas() : NodeListOf<HTMLCanvasElement> = jsNative
    [<Emit("$0.getElementsByTagName('caption')")>] member __.getElementsByTagName_caption() : NodeListOf<HTMLTableCaptionElement> = jsNative
    [<Emit("$0.getElementsByTagName('center')")>] member __.getElementsByTagName_center() : NodeListOf<HTMLBlockElement> = jsNative
    //[<Emit("$0.getElementsByTagName('circle')")>] member __.getElementsByTagName_circle() : NodeListOf<SVGCircleElement> = jsNative
    [<Emit("$0.getElementsByTagName('cite')")>] member __.getElementsByTagName_cite() : NodeListOf<HTMLPhraseElement> = jsNative
    //[<Emit("$0.getElementsByTagName('clippath')")>] member __.getElementsByTagName_clippath() : NodeListOf<SVGClipPathElement> = jsNative
    [<Emit("$0.getElementsByTagName('code')")>] member __.getElementsByTagName_code() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('col')")>] member __.getElementsByTagName_col() : NodeListOf<HTMLTableColElement> = jsNative
    [<Emit("$0.getElementsByTagName('colgroup')")>] member __.getElementsByTagName_colgroup() : NodeListOf<HTMLTableColElement> = jsNative
    [<Emit("$0.getElementsByTagName('datalist')")>] member __.getElementsByTagName_datalist() : NodeListOf<HTMLDataListElement> = jsNative
    [<Emit("$0.getElementsByTagName('dd')")>] member __.getElementsByTagName_dd() : NodeListOf<HTMLDDElement> = jsNative
    //[<Emit("$0.getElementsByTagName('defs')")>] member __.getElementsByTagName_defs() : NodeListOf<SVGDefsElement> = jsNative
    [<Emit("$0.getElementsByTagName('del')")>] member __.getElementsByTagName_del() : NodeListOf<HTMLModElement> = jsNative
    //[<Emit("$0.getElementsByTagName('desc')")>] member __.getElementsByTagName_desc() : NodeListOf<SVGDescElement> = jsNative
    [<Emit("$0.getElementsByTagName('dfn')")>] member __.getElementsByTagName_dfn() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('dir')")>] member __.getElementsByTagName_dir() : NodeListOf<HTMLDirectoryElement> = jsNative
    [<Emit("$0.getElementsByTagName('div')")>] member __.getElementsByTagName_div() : NodeListOf<HTMLDivElement> = jsNative
    [<Emit("$0.getElementsByTagName('dl')")>] member __.getElementsByTagName_dl() : NodeListOf<HTMLDListElement> = jsNative
    [<Emit("$0.getElementsByTagName('dt')")>] member __.getElementsByTagName_dt() : NodeListOf<HTMLDTElement> = jsNative
    //[<Emit("$0.getElementsByTagName('ellipse')")>] member __.getElementsByTagName_ellipse() : NodeListOf<SVGEllipseElement> = jsNative
    [<Emit("$0.getElementsByTagName('em')")>] member __.getElementsByTagName_em() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('embed')")>] member __.getElementsByTagName_embed() : NodeListOf<HTMLEmbedElement> = jsNative
    //[<Emit("$0.getElementsByTagName('feblend')")>] member __.getElementsByTagName_feblend() : NodeListOf<SVGFEBlendElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fecolormatrix')")>] member __.getElementsByTagName_fecolormatrix() : NodeListOf<SVGFEColorMatrixElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fecomponenttransfer')")>] member __.getElementsByTagName_fecomponenttransfer() : NodeListOf<SVGFEComponentTransferElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fecomposite')")>] member __.getElementsByTagName_fecomposite() : NodeListOf<SVGFECompositeElement> = jsNative
    //[<Emit("$0.getElementsByTagName('feconvolvematrix')")>] member __.getElementsByTagName_feconvolvematrix() : NodeListOf<SVGFEConvolveMatrixElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fediffuselighting')")>] member __.getElementsByTagName_fediffuselighting() : NodeListOf<SVGFEDiffuseLightingElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fedisplacementmap')")>] member __.getElementsByTagName_fedisplacementmap() : NodeListOf<SVGFEDisplacementMapElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fedistantlight')")>] member __.getElementsByTagName_fedistantlight() : NodeListOf<SVGFEDistantLightElement> = jsNative
    //[<Emit("$0.getElementsByTagName('feflood')")>] member __.getElementsByTagName_feflood() : NodeListOf<SVGFEFloodElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fefunca')")>] member __.getElementsByTagName_fefunca() : NodeListOf<SVGFEFuncAElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fefuncb')")>] member __.getElementsByTagName_fefuncb() : NodeListOf<SVGFEFuncBElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fefuncg')")>] member __.getElementsByTagName_fefuncg() : NodeListOf<SVGFEFuncGElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fefuncr')")>] member __.getElementsByTagName_fefuncr() : NodeListOf<SVGFEFuncRElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fegaussianblur')")>] member __.getElementsByTagName_fegaussianblur() : NodeListOf<SVGFEGaussianBlurElement> = jsNative
    //[<Emit("$0.getElementsByTagName('feimage')")>] member __.getElementsByTagName_feimage() : NodeListOf<SVGFEImageElement> = jsNative
    //[<Emit("$0.getElementsByTagName('femerge')")>] member __.getElementsByTagName_femerge() : NodeListOf<SVGFEMergeElement> = jsNative
    //[<Emit("$0.getElementsByTagName('femergenode')")>] member __.getElementsByTagName_femergenode() : NodeListOf<SVGFEMergeNodeElement> = jsNative
    //[<Emit("$0.getElementsByTagName('femorphology')")>] member __.getElementsByTagName_femorphology() : NodeListOf<SVGFEMorphologyElement> = jsNative
    //[<Emit("$0.getElementsByTagName('feoffset')")>] member __.getElementsByTagName_feoffset() : NodeListOf<SVGFEOffsetElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fepointlight')")>] member __.getElementsByTagName_fepointlight() : NodeListOf<SVGFEPointLightElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fespecularlighting')")>] member __.getElementsByTagName_fespecularlighting() : NodeListOf<SVGFESpecularLightingElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fespotlight')")>] member __.getElementsByTagName_fespotlight() : NodeListOf<SVGFESpotLightElement> = jsNative
    //[<Emit("$0.getElementsByTagName('fetile')")>] member __.getElementsByTagName_fetile() : NodeListOf<SVGFETileElement> = jsNative
    //[<Emit("$0.getElementsByTagName('feturbulence')")>] member __.getElementsByTagName_feturbulence() : NodeListOf<SVGFETurbulenceElement> = jsNative
    [<Emit("$0.getElementsByTagName('fieldset')")>] member __.getElementsByTagName_fieldset() : NodeListOf<HTMLFieldSetElement> = jsNative
    [<Emit("$0.getElementsByTagName('figcaption')")>] member __.getElementsByTagName_figcaption() : NodeListOf<HTMLElement> = jsNative
    [<Emit("$0.getElementsByTagName('figure')")>] member __.getElementsByTagName_figure() : NodeListOf<HTMLElement> = jsNative
    //[<Emit("$0.getElementsByTagName('filter')")>] member __.getElementsByTagName_filter() : NodeListOf<SVGFilterElement> = jsNative
    [<Emit("$0.getElementsByTagName('font')")>] member __.getElementsByTagName_font() : NodeListOf<HTMLFontElement> = jsNative
    [<Emit("$0.getElementsByTagName('footer')")>] member __.getElementsByTagName_footer() : NodeListOf<HTMLElement> = jsNative
    //[<Emit("$0.getElementsByTagName('foreignobject')")>] member __.getElementsByTagName_foreignobject() : NodeListOf<SVGForeignObjectElement> = jsNative
    [<Emit("$0.getElementsByTagName('form')")>] member __.getElementsByTagName_form() : NodeListOf<HTMLFormElement> = jsNative
    [<Emit("$0.getElementsByTagName('frame')")>] member __.getElementsByTagName_frame() : NodeListOf<HTMLFrameElement> = jsNative
    //[<Emit("$0.getElementsByTagName('frameset')")>] member __.getElementsByTagName_frameset() : NodeListOf<HTMLFrameSetElement> = jsNative
    //[<Emit("$0.getElementsByTagName('g')")>] member __.getElementsByTagName_g() : NodeListOf<SVGGElement> = jsNative
    [<Emit("$0.getElementsByTagName('h1')")>] member __.getElementsByTagName_h1() : NodeListOf<HTMLHeadingElement> = jsNative
    [<Emit("$0.getElementsByTagName('h2')")>] member __.getElementsByTagName_h2() : NodeListOf<HTMLHeadingElement> = jsNative
    [<Emit("$0.getElementsByTagName('h3')")>] member __.getElementsByTagName_h3() : NodeListOf<HTMLHeadingElement> = jsNative
    [<Emit("$0.getElementsByTagName('h4')")>] member __.getElementsByTagName_h4() : NodeListOf<HTMLHeadingElement> = jsNative
    [<Emit("$0.getElementsByTagName('h5')")>] member __.getElementsByTagName_h5() : NodeListOf<HTMLHeadingElement> = jsNative
    [<Emit("$0.getElementsByTagName('h6')")>] member __.getElementsByTagName_h6() : NodeListOf<HTMLHeadingElement> = jsNative
    [<Emit("$0.getElementsByTagName('head')")>] member __.getElementsByTagName_head() : NodeListOf<HTMLHeadElement> = jsNative
    [<Emit("$0.getElementsByTagName('header')")>] member __.getElementsByTagName_header() : NodeListOf<HTMLElement> = jsNative
    [<Emit("$0.getElementsByTagName('hgroup')")>] member __.getElementsByTagName_hgroup() : NodeListOf<HTMLElement> = jsNative
    [<Emit("$0.getElementsByTagName('hr')")>] member __.getElementsByTagName_hr() : NodeListOf<HTMLHRElement> = jsNative
    [<Emit("$0.getElementsByTagName('html')")>] member __.getElementsByTagName_html() : NodeListOf<HTMLHtmlElement> = jsNative
    [<Emit("$0.getElementsByTagName('i')")>] member __.getElementsByTagName_i() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('iframe')")>] member __.getElementsByTagName_iframe() : NodeListOf<HTMLIFrameElement> = jsNative
    //[<Emit("$0.getElementsByTagName('image')")>] member __.getElementsByTagName_image() : NodeListOf<SVGImageElement> = jsNative
    [<Emit("$0.getElementsByTagName('img')")>] member __.getElementsByTagName_img() : NodeListOf<HTMLImageElement> = jsNative
    [<Emit("$0.getElementsByTagName('input')")>] member __.getElementsByTagName_input() : NodeListOf<HTMLInputElement> = jsNative
    [<Emit("$0.getElementsByTagName('ins')")>] member __.getElementsByTagName_ins() : NodeListOf<HTMLModElement> = jsNative
    //[<Emit("$0.getElementsByTagName('isindex')")>] member __.getElementsByTagName_isindex() : NodeListOf<HTMLIsIndexElement> = jsNative
    [<Emit("$0.getElementsByTagName('kbd')")>] member __.getElementsByTagName_kbd() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('keygen')")>] member __.getElementsByTagName_keygen() : NodeListOf<HTMLBlockElement> = jsNative
    [<Emit("$0.getElementsByTagName('label')")>] member __.getElementsByTagName_label() : NodeListOf<HTMLLabelElement> = jsNative
    [<Emit("$0.getElementsByTagName('legend')")>] member __.getElementsByTagName_legend() : NodeListOf<HTMLLegendElement> = jsNative
    [<Emit("$0.getElementsByTagName('li')")>] member __.getElementsByTagName_li() : NodeListOf<HTMLLIElement> = jsNative
    //[<Emit("$0.getElementsByTagName('line')")>] member __.getElementsByTagName_line() : NodeListOf<SVGLineElement> = jsNative
    //[<Emit("$0.getElementsByTagName('lineargradient')")>] member __.getElementsByTagName_lineargradient() : NodeListOf<SVGLinearGradientElement> = jsNative
    [<Emit("$0.getElementsByTagName('link')")>] member __.getElementsByTagName_link() : NodeListOf<HTMLLinkElement> = jsNative
    [<Emit("$0.getElementsByTagName('listing')")>] member __.getElementsByTagName_listing() : NodeListOf<HTMLBlockElement> = jsNative
    [<Emit("$0.getElementsByTagName('map')")>] member __.getElementsByTagName_map() : NodeListOf<HTMLMapElement> = jsNative
    [<Emit("$0.getElementsByTagName('mark')")>] member __.getElementsByTagName_mark() : NodeListOf<HTMLElement> = jsNative
    //[<Emit("$0.getElementsByTagName('marker')")>] member __.getElementsByTagName_marker() : NodeListOf<SVGMarkerElement> = jsNative
    //[<Emit("$0.getElementsByTagName('marquee')")>] member __.getElementsByTagName_marquee() : NodeListOf<HTMLMarqueeElement> = jsNative
    //[<Emit("$0.getElementsByTagName('mask')")>] member __.getElementsByTagName_mask() : NodeListOf<SVGMaskElement> = jsNative
    [<Emit("$0.getElementsByTagName('menu')")>] member __.getElementsByTagName_menu() : NodeListOf<HTMLMenuElement> = jsNative
    [<Emit("$0.getElementsByTagName('meta')")>] member __.getElementsByTagName_meta() : NodeListOf<HTMLMetaElement> = jsNative
    //[<Emit("$0.getElementsByTagName('metadata')")>] member __.getElementsByTagName_metadata() : NodeListOf<SVGMetadataElement> = jsNative
    [<Emit("$0.getElementsByTagName('nav')")>] member __.getElementsByTagName_nav() : NodeListOf<HTMLElement> = jsNative
    [<Emit("$0.getElementsByTagName('nextid')")>] member __.getElementsByTagName_nextid() : NodeListOf<HTMLNextIdElement> = jsNative
    [<Emit("$0.getElementsByTagName('nobr')")>] member __.getElementsByTagName_nobr() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('noframes')")>] member __.getElementsByTagName_noframes() : NodeListOf<HTMLElement> = jsNative
    [<Emit("$0.getElementsByTagName('noscript')")>] member __.getElementsByTagName_noscript() : NodeListOf<HTMLElement> = jsNative
    [<Emit("$0.getElementsByTagName('object')")>] member __.getElementsByTagName_object() : NodeListOf<HTMLObjectElement> = jsNative
    [<Emit("$0.getElementsByTagName('ol')")>] member __.getElementsByTagName_ol() : NodeListOf<HTMLOListElement> = jsNative
    [<Emit("$0.getElementsByTagName('optgroup')")>] member __.getElementsByTagName_optgroup() : NodeListOf<HTMLOptGroupElement> = jsNative
    [<Emit("$0.getElementsByTagName('option')")>] member __.getElementsByTagName_option() : NodeListOf<HTMLOptionElement> = jsNative
    [<Emit("$0.getElementsByTagName('p')")>] member __.getElementsByTagName_p() : NodeListOf<HTMLParagraphElement> = jsNative
    [<Emit("$0.getElementsByTagName('param')")>] member __.getElementsByTagName_param() : NodeListOf<HTMLParamElement> = jsNative
    //[<Emit("$0.getElementsByTagName('path')")>] member __.getElementsByTagName_path() : NodeListOf<SVGPathElement> = jsNative
    //[<Emit("$0.getElementsByTagName('pattern')")>] member __.getElementsByTagName_pattern() : NodeListOf<SVGPatternElement> = jsNative
    //[<Emit("$0.getElementsByTagName('picture')")>] member __.getElementsByTagName_picture() : NodeListOf<HTMLPictureElement> = jsNative
    [<Emit("$0.getElementsByTagName('plaintext')")>] member __.getElementsByTagName_plaintext() : NodeListOf<HTMLBlockElement> = jsNative
    //[<Emit("$0.getElementsByTagName('polygon')")>] member __.getElementsByTagName_polygon() : NodeListOf<SVGPolygonElement> = jsNative
    //[<Emit("$0.getElementsByTagName('polyline')")>] member __.getElementsByTagName_polyline() : NodeListOf<SVGPolylineElement> = jsNative
    [<Emit("$0.getElementsByTagName('pre')")>] member __.getElementsByTagName_pre() : NodeListOf<HTMLPreElement> = jsNative
    [<Emit("$0.getElementsByTagName('progress')")>] member __.getElementsByTagName_progress() : NodeListOf<HTMLProgressElement> = jsNative
    [<Emit("$0.getElementsByTagName('q')")>] member __.getElementsByTagName_q() : NodeListOf<HTMLQuoteElement> = jsNative
    //[<Emit("$0.getElementsByTagName('radialgradient')")>] member __.getElementsByTagName_radialgradient() : NodeListOf<SVGRadialGradientElement> = jsNative
    //[<Emit("$0.getElementsByTagName('rect')")>] member __.getElementsByTagName_rect() : NodeListOf<SVGRectElement> = jsNative
    [<Emit("$0.getElementsByTagName('rt')")>] member __.getElementsByTagName_rt() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('ruby')")>] member __.getElementsByTagName_ruby() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('s')")>] member __.getElementsByTagName_s() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('samp')")>] member __.getElementsByTagName_samp() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('script')")>] member __.getElementsByTagName_script() : NodeListOf<HTMLScriptElement> = jsNative
    [<Emit("$0.getElementsByTagName('section')")>] member __.getElementsByTagName_section() : NodeListOf<HTMLElement> = jsNative
    [<Emit("$0.getElementsByTagName('select')")>] member __.getElementsByTagName_select() : NodeListOf<HTMLSelectElement> = jsNative
    [<Emit("$0.getElementsByTagName('small')")>] member __.getElementsByTagName_small() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('source')")>] member __.getElementsByTagName_source() : NodeListOf<HTMLSourceElement> = jsNative
    [<Emit("$0.getElementsByTagName('span')")>] member __.getElementsByTagName_span() : NodeListOf<HTMLSpanElement> = jsNative
    //[<Emit("$0.getElementsByTagName('stop')")>] member __.getElementsByTagName_stop() : NodeListOf<SVGStopElement> = jsNative
    [<Emit("$0.getElementsByTagName('strike')")>] member __.getElementsByTagName_strike() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('strong')")>] member __.getElementsByTagName_strong() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('style')")>] member __.getElementsByTagName_style() : NodeListOf<HTMLStyleElement> = jsNative
    [<Emit("$0.getElementsByTagName('sub')")>] member __.getElementsByTagName_sub() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('sup')")>] member __.getElementsByTagName_sup() : NodeListOf<HTMLPhraseElement> = jsNative
    //[<Emit("$0.getElementsByTagName('svg')")>] member __.getElementsByTagName_svg() : NodeListOf<SVGSVGElement> = jsNative
    //[<Emit("$0.getElementsByTagName('switch')")>] member __.getElementsByTagName_switch() : NodeListOf<SVGSwitchElement> = jsNative
    //[<Emit("$0.getElementsByTagName('symbol')")>] member __.getElementsByTagName_symbol() : NodeListOf<SVGSymbolElement> = jsNative
    [<Emit("$0.getElementsByTagName('table')")>] member __.getElementsByTagName_table() : NodeListOf<HTMLTableElement> = jsNative
    [<Emit("$0.getElementsByTagName('tbody')")>] member __.getElementsByTagName_tbody() : NodeListOf<HTMLTableSectionElement> = jsNative
    [<Emit("$0.getElementsByTagName('td')")>] member __.getElementsByTagName_td() : NodeListOf<HTMLTableDataCellElement> = jsNative
    //[<Emit("$0.getElementsByTagName('text')")>] member __.getElementsByTagName_text() : NodeListOf<SVGTextElement> = jsNative
    //[<Emit("$0.getElementsByTagName('textpath')")>] member __.getElementsByTagName_textpath() : NodeListOf<SVGTextPathElement> = jsNative
    [<Emit("$0.getElementsByTagName('textarea')")>] member __.getElementsByTagName_textarea() : NodeListOf<HTMLTextAreaElement> = jsNative
    [<Emit("$0.getElementsByTagName('tfoot')")>] member __.getElementsByTagName_tfoot() : NodeListOf<HTMLTableSectionElement> = jsNative
    [<Emit("$0.getElementsByTagName('th')")>] member __.getElementsByTagName_th() : NodeListOf<HTMLTableHeaderCellElement> = jsNative
    [<Emit("$0.getElementsByTagName('thead')")>] member __.getElementsByTagName_thead() : NodeListOf<HTMLTableSectionElement> = jsNative
    [<Emit("$0.getElementsByTagName('title')")>] member __.getElementsByTagName_title() : NodeListOf<HTMLTitleElement> = jsNative
    [<Emit("$0.getElementsByTagName('tr')")>] member __.getElementsByTagName_tr() : NodeListOf<HTMLTableRowElement> = jsNative
    [<Emit("$0.getElementsByTagName('track')")>] member __.getElementsByTagName_track() : NodeListOf<HTMLTrackElement> = jsNative
    //[<Emit("$0.getElementsByTagName('tspan')")>] member __.getElementsByTagName_tspan() : NodeListOf<SVGTSpanElement> = jsNative
    [<Emit("$0.getElementsByTagName('tt')")>] member __.getElementsByTagName_tt() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('u')")>] member __.getElementsByTagName_u() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('ul')")>] member __.getElementsByTagName_ul() : NodeListOf<HTMLUListElement> = jsNative
    //[<Emit("$0.getElementsByTagName('use')")>] member __.getElementsByTagName_use() : NodeListOf<SVGUseElement> = jsNative
    [<Emit("$0.getElementsByTagName('var')")>] member __.getElementsByTagName_var() : NodeListOf<HTMLPhraseElement> = jsNative
    [<Emit("$0.getElementsByTagName('video')")>] member __.getElementsByTagName_video() : NodeListOf<HTMLVideoElement> = jsNative
    //[<Emit("$0.getElementsByTagName('view')")>] member __.getElementsByTagName_view() : NodeListOf<SVGViewElement> = jsNative
    [<Emit("$0.getElementsByTagName('wbr')")>] member __.getElementsByTagName_wbr() : NodeListOf<HTMLElement> = jsNative
    //[<Emit("$0.getElementsByTagName('x-ms-webview')")>] member __.``getElementsByTagName_x-ms-webview``() : NodeListOf<MSHTMLWebViewElement> = fsOnly
    [<Emit("$0.getElementsByTagName('xmp')")>] member __.getElementsByTagName_xmp() : NodeListOf<HTMLBlockElement> = jsNative
    