

let tl = gsap.timeline();
tl.to(".box", {duration: 1, x:20})
tl.to(".text", {rotation: 360, duration: 1},"-=1" )
tl.add("textarrive", "+=1")
var tl1=tl.to(".text", {duration: 2, x: 854})
tl.to(".box", {duration: 1, rotation:360}, "textarrive-=0.5")

