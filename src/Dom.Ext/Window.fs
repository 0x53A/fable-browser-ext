[<AutoOpen>]
module Browser.DomExtensions_Window

open Fable.Core
open Browser.Types

type Window with

    //[<Emit("$0.addEventListener('MSGestureChange',$1...)")>] member __.addEventListener_MSGestureChange(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureDoubleTap',$1...)")>] member __.addEventListener_MSGestureDoubleTap(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureEnd',$1...)")>] member __.addEventListener_MSGestureEnd(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureHold',$1...)")>] member __.addEventListener_MSGestureHold(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureStart',$1...)")>] member __.addEventListener_MSGestureStart(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSGestureTap',$1...)")>] member __.addEventListener_MSGestureTap(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSInertiaStart',$1...)")>] member __.addEventListener_MSInertiaStart(listener: (MSGestureEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerCancel',$1...)")>] member __.addEventListener_MSPointerCancel(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerDown',$1...)")>] member __.addEventListener_MSPointerDown(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerEnter',$1...)")>] member __.addEventListener_MSPointerEnter(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerLeave',$1...)")>] member __.addEventListener_MSPointerLeave(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerMove',$1...)")>] member __.addEventListener_MSPointerMove(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerOut',$1...)")>] member __.addEventListener_MSPointerOut(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerOver',$1...)")>] member __.addEventListener_MSPointerOver(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    //[<Emit("$0.addEventListener('MSPointerUp',$1...)")>] member __.addEventListener_MSPointerUp(listener: (MSPointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('abort',$1...)")>] member __.addEventListener_abort(listener: (UIEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('afterprint',$1...)")>] member __.addEventListener_afterprint(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('beforeprint',$1...)")>] member __.addEventListener_beforeprint(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('beforeunload',$1...)")>] member __.addEventListener_beforeunload(listener: (BeforeUnloadEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('blur',$1...)")>] member __.addEventListener_blur(listener: (FocusEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('canplay',$1...)")>] member __.addEventListener_canplay(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('canplaythrough',$1...)")>] member __.addEventListener_canplaythrough(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('change',$1...)")>] member __.addEventListener_change(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('click',$1...)")>] member __.addEventListener_click(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('compassneedscalibration',$1...)")>] member __.addEventListener_compassneedscalibration(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('contextmenu',$1...)")>] member __.addEventListener_contextmenu(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('dblclick',$1...)")>] member __.addEventListener_dblclick(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('devicemotion',$1...)")>] member __.addEventListener_devicemotion(listener: (DeviceMotionEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('deviceorientation',$1...)")>] member __.addEventListener_deviceorientation(listener: (DeviceOrientationEvent -> 'Out), ?useCapture: bool) = jsNative
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
    [<Emit("$0.addEventListener('focus',$1...)")>] member __.addEventListener_focus(listener: (FocusEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('hashchange',$1...)")>] member __.addEventListener_hashchange(listener: (HashChangeEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('input',$1...)")>] member __.addEventListener_input(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('keydown',$1...)")>] member __.addEventListener_keydown(listener: (KeyboardEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('keypress',$1...)")>] member __.addEventListener_keypress(listener: (KeyboardEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('keyup',$1...)")>] member __.addEventListener_keyup(listener: (KeyboardEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('load',$1...)")>] member __.addEventListener_load(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('loadeddata',$1...)")>] member __.addEventListener_loadeddata(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('loadedmetadata',$1...)")>] member __.addEventListener_loadedmetadata(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('loadstart',$1...)")>] member __.addEventListener_loadstart(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('message',$1...)")>] member __.addEventListener_message(listener: (MessageEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mousedown',$1...)")>] member __.addEventListener_mousedown(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mouseenter',$1...)")>] member __.addEventListener_mouseenter(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mouseleave',$1...)")>] member __.addEventListener_mouseleave(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mousemove',$1...)")>] member __.addEventListener_mousemove(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mouseout',$1...)")>] member __.addEventListener_mouseout(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mouseover',$1...)")>] member __.addEventListener_mouseover(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mouseup',$1...)")>] member __.addEventListener_mouseup(listener: (MouseEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('mousewheel',$1...)")>] member __.addEventListener_mousewheel(listener: (MouseWheelEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('offline',$1...)")>] member __.addEventListener_offline(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('online',$1...)")>] member __.addEventListener_online(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('orientationchange',$1...)")>] member __.addEventListener_orientationchange(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pagehide',$1...)")>] member __.addEventListener_pagehide(listener: (PageTransitionEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pageshow',$1...)")>] member __.addEventListener_pageshow(listener: (PageTransitionEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pause',$1...)")>] member __.addEventListener_pause(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('play',$1...)")>] member __.addEventListener_play(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('playing',$1...)")>] member __.addEventListener_playing(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('popstate',$1...)")>] member __.addEventListener_popstate(listener: (PopStateEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('progress',$1...)")>] member __.addEventListener_progress(listener: (ProgressEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('ratechange',$1...)")>] member __.addEventListener_ratechange(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('readystatechange',$1...)")>] member __.addEventListener_readystatechange(listener: (ProgressEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('reset',$1...)")>] member __.addEventListener_reset(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('resize',$1...)")>] member __.addEventListener_resize(listener: (UIEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('scroll',$1...)")>] member __.addEventListener_scroll(listener: (UIEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('seeked',$1...)")>] member __.addEventListener_seeked(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('seeking',$1...)")>] member __.addEventListener_seeking(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('select',$1...)")>] member __.addEventListener_select(listener: (UIEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('stalled',$1...)")>] member __.addEventListener_stalled(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('storage',$1...)")>] member __.addEventListener_storage(listener: (StorageEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('submit',$1...)")>] member __.addEventListener_submit(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('suspend',$1...)")>] member __.addEventListener_suspend(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('timeupdate',$1...)")>] member __.addEventListener_timeupdate(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('unload',$1...)")>] member __.addEventListener_unload(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('volumechange',$1...)")>] member __.addEventListener_volumechange(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('waiting',$1...)")>] member __.addEventListener_waiting(listener: (Event -> 'Out), ?useCapture: bool) = jsNative
