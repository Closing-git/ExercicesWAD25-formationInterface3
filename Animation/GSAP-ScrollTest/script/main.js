gsap.registerPlugin(ScrollTrigger);

gsap.to("#green", {

    x: 400,
    rotation : 360,
    duration : 3
})

let tl = gsap.timeline({
    scrollTrigger: {
    //Ce qui déclenche l'animation
    trigger:"#orange",
    //Quelle partie de l'objet déclenche l'animation (ici le top) et par rapport à quelle partie de l'écran (ici le center) et ça peut être aussi en px ou %
    start: "top center",
    end: "200px center",
    //Marqueurs visuels pour s'aider :
    markers: true,
    //Suit l'animation avec le scroll, si True ça suit simplement l'animation, si on met un chiffre il y a un certain retard sur l'anim
    scrub: 3,

    //Le type de comportement avec ToggleActions
    //1 : quand on ré-arrive sur l'élément 2: quand on le dépasse  3 : quand on y revient (depuis en bas) 4 : pas clair
    // toggleActions: "restart pause resume pause"
},

});


tl.to("#orange", {

    //On peut mettre le scrollTrigger ici si on note gsap.to à la place de tl.to OU comme en haut, si on veut l'inclure dans une timeline
    // scrollTrigger: {
    //     //Ce qui déclenche l'animation
    //     trigger:"#orange",
    //     //Quelle partie de l'objet déclenche l'animation (ici le top) et par rapport à quelle partie de l'écran (ici le center) et ça peut être aussi en px ou %
    //     start: "top center",
    //     end: "200px center",
    //     //Marqueurs visuels pour s'aider :
    //     markers: true,
    //     //Suit l'animation avec le scroll, si True ça suit simplement l'animation, si on met un chiffre il y a un certain retard sur l'anim
    //     scrub: 3,
    // },
    x: 400,
    rotation : 360,
    duration : 3
})