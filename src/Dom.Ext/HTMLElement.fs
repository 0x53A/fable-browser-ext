[<AutoOpen>]
module Browser.DomExtensions_HTMLElement

open Fable.Core
open Browser.Types

type HTMLElement with

    [<Emit("$0.addEventListener('MSContentZoom',$1...)")>] member __.addEventListener_MSContentZoom(listener: (UIEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureChange',$1...)")>] member __.addEventListener_MSGestureChange(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureDoubleTap',$1...)")>] member __.addEventListener_MSGestureDoubleTap(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureEnd',$1...)")>] member __.addEventListener_MSGestureEnd(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureHold',$1...)")>] member __.addEventListener_MSGestureHold(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureStart',$1...)")>] member __.addEventListener_MSGestureStart(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureTap',$1...)")>] member __.addEventListener_MSGestureTap(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGotPointerCapture',$1...)")>] member __.addEventListener_MSGotPointerCapture(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSInertiaStart',$1...)")>] member __.addEventListener_MSInertiaStart(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSLostPointerCapture',$1...)")>] member __.addEventListener_MSLostPointerCapture(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSManipulationStateChanged',$1...)")>] member __.addEventListener_MSManipulationStateChanged(listener: (MSManipulationEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerCancel',$1...)")>] member __.addEventListener_MSPointerCancel(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerDown',$1...)")>] member __.addEventListener_MSPointerDown(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerEnter',$1...)")>] member __.addEventListener_MSPointerEnter(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerLeave',$1...)")>] member __.addEventListener_MSPointerLeave(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerMove',$1...)")>] member __.addEventListener_MSPointerMove(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerOut',$1...)")>] member __.addEventListener_MSPointerOut(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerOver',$1...)")>] member __.addEventListener_MSPointerOver(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerUp',$1...)")>] member __.addEventListener_MSPointerUp(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('abort',$1...)")>] member __.addEventListener_abort(listener: (UIEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('activate',$1...)")>] member __.addEventListener_activate(listener: (UIEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('ariarequest',$1...)")>] member __.addEventListener_ariarequest(listener: (AriaRequestEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('beforeactivate',$1...)")>] member __.addEventListener_beforeactivate(listener: (UIEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('beforecopy',$1...)")>] member __.addEventListener_beforecopy(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('beforecut',$1...)")>] member __.addEventListener_beforecut(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('beforedeactivate',$1...)")>] member __.addEventListener_beforedeactivate(listener: (UIEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('beforepaste',$1...)")>] member __.addEventListener_beforepaste(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('blur',$1...)")>] member __.addEventListener_blur(listener: (FocusEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('canplay',$1...)")>] member __.addEventListener_canplay(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('canplaythrough',$1...)")>] member __.addEventListener_canplaythrough(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('change',$1...)")>] member __.addEventListener_change(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('click',$1...)")>] member __.addEventListener_click(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('command',$1...)")>] member __.addEventListener_command(listener: (CommandEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('contextmenu',$1...)")>] member __.addEventListener_contextmenu(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('copy',$1...)")>] member __.addEventListener_copy(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('cuechange',$1...)")>] member __.addEventListener_cuechange(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('cut',$1...)")>] member __.addEventListener_cut(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('dblclick',$1...)")>] member __.addEventListener_dblclick(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('deactivate',$1...)")>] member __.addEventListener_deactivate(listener: (UIEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('drag',$1...)")>] member __.addEventListener_drag(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('dragend',$1...)")>] member __.addEventListener_dragend(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('dragenter',$1...)")>] member __.addEventListener_dragenter(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('dragleave',$1...)")>] member __.addEventListener_dragleave(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('dragover',$1...)")>] member __.addEventListener_dragover(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('dragstart',$1...)")>] member __.addEventListener_dragstart(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('drop',$1...)")>] member __.addEventListener_drop(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('durationchange',$1...)")>] member __.addEventListener_durationchange(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('emptied',$1...)")>] member __.addEventListener_emptied(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('ended',$1...)")>] member __.addEventListener_ended(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('error',$1...)")>] member __.addEventListener_error(listener: (ErrorEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('focus',$1...)")>] member __.addEventListener_focus(listener: (FocusEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('gotpointercapture',$1...)")>] member __.addEventListener_gotpointercapture(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('input',$1...)")>] member __.addEventListener_input(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('keydown',$1...)")>] member __.addEventListener_keydown(listener: (KeyboardEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('keypress',$1...)")>] member __.addEventListener_keypress(listener: (KeyboardEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('keyup',$1...)")>] member __.addEventListener_keyup(listener: (KeyboardEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('load',$1...)")>] member __.addEventListener_load(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('loadeddata',$1...)")>] member __.addEventListener_loadeddata(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('loadedmetadata',$1...)")>] member __.addEventListener_loadedmetadata(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('loadstart',$1...)")>] member __.addEventListener_loadstart(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('lostpointercapture',$1...)")>] member __.addEventListener_lostpointercapture(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mousedown',$1...)")>] member __.addEventListener_mousedown(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mouseenter',$1...)")>] member __.addEventListener_mouseenter(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mouseleave',$1...)")>] member __.addEventListener_mouseleave(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mousemove',$1...)")>] member __.addEventListener_mousemove(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mouseout',$1...)")>] member __.addEventListener_mouseout(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mouseover',$1...)")>] member __.addEventListener_mouseover(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mouseup',$1...)")>] member __.addEventListener_mouseup(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mousewheel',$1...)")>] member __.addEventListener_mousewheel(listener: (MouseWheelEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('paste',$1...)")>] member __.addEventListener_paste(listener: (DragEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pause',$1...)")>] member __.addEventListener_pause(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('play',$1...)")>] member __.addEventListener_play(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('playing',$1...)")>] member __.addEventListener_playing(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointercancel',$1...)")>] member __.addEventListener_pointercancel(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointerdown',$1...)")>] member __.addEventListener_pointerdown(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointerenter',$1...)")>] member __.addEventListener_pointerenter(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointerleave',$1...)")>] member __.addEventListener_pointerleave(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointermove',$1...)")>] member __.addEventListener_pointermove(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointerout',$1...)")>] member __.addEventListener_pointerout(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointerover',$1...)")>] member __.addEventListener_pointerover(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointerup',$1...)")>] member __.addEventListener_pointerup(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('progress',$1...)")>] member __.addEventListener_progress(listener: (ProgressEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('ratechange',$1...)")>] member __.addEventListener_ratechange(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('reset',$1...)")>] member __.addEventListener_reset(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('scroll',$1...)")>] member __.addEventListener_scroll(listener: (UIEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('seeked',$1...)")>] member __.addEventListener_seeked(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('seeking',$1...)")>] member __.addEventListener_seeking(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('select',$1...)")>] member __.addEventListener_select(listener: (UIEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('selectstart',$1...)")>] member __.addEventListener_selectstart(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('stalled',$1...)")>] member __.addEventListener_stalled(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('submit',$1...)")>] member __.addEventListener_submit(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('suspend',$1...)")>] member __.addEventListener_suspend(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('timeupdate',$1...)")>] member __.addEventListener_timeupdate(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('touchcancel',$1...)")>] member __.addEventListener_touchcancel(listener: (TouchEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('touchend',$1...)")>] member __.addEventListener_touchend(listener: (TouchEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('touchmove',$1...)")>] member __.addEventListener_touchmove(listener: (TouchEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('touchstart',$1...)")>] member __.addEventListener_touchstart(listener: (TouchEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('volumechange',$1...)")>] member __.addEventListener_volumechange(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('waiting',$1...)")>] member __.addEventListener_waiting(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('webkitfullscreenchange',$1...)")>] member __.addEventListener_webkitfullscreenchange(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('webkitfullscreenerror',$1...)")>] member __.addEventListener_webkitfullscreenerror(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('wheel',$1...)")>] member __.addEventListener_wheel(listener: (WheelEvent -> 'Out), ?useCapture: bool) = jsNative
