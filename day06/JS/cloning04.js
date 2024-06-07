const nextBtn = document.querySelector('.next-btn');
const prevBtn = document.querySelector('.prev-btn');
const slides = document.querySelectorAll('.slide');
const numberOfslides = slides.length;
let slideNumber = 0;

//slider next button
nextBtn.onclick = function() {
    slides.forEach((slide) => {
        slide.classList.remove('active');
    });

    slideNumber++;

    if(slideNumber > (numberOfslides-1)){
        slideNumber = 0;
    }

    slides[slideNumber].classList.add('active');
};

//slider prev button
prevBtn.onclick = () => {
    slides.forEach((slide)=>{
        slide.classList.remove('active');
    });
    slideNumber--;

    if(slideNumber < 0){
        slideNumber = numberOfslides-1;
    }
    slides[slideNumber].classList.add('active');
};