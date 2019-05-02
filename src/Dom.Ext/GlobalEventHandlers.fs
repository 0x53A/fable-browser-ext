[<AutoOpen>]
module Browser.DomExtensions_GlobalEventHandlers

open Fable.Core
open Browser.Types

type GlobalEventHandlers with
    [<Emit("$0.addEventListener('pointercancel',$1...)")>]  member __.addEventListener_pointercancel(listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointerdown',$1...)")>]    member __.addEventListener_pointerdown  (listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointerenter',$1...)")>]   member __.addEventListener_pointerenter (listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointerleave',$1...)")>]   member __.addEventListener_pointerleave (listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointermove',$1...)")>]    member __.addEventListener_pointermove  (listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointerout',$1...)")>]     member __.addEventListener_pointerout   (listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointerover',$1...)")>]    member __.addEventListener_pointerover  (listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('pointerup',$1...)")>]      member __.addEventListener_pointerup    (listener: (PointerEvent -> 'Out), ?useCapture: bool) = jsNative
    [<Emit("$0.addEventListener('wheel',$1...)")>]          member __.addEventListener_wheel        (listener: (WheelEvent -> 'Out)  , ?useCapture: bool) = jsNative
