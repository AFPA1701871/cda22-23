var titleColor = ["red","blue","green"];
var paragraphsColor = ["red", "blue"];
var compteurTitle = 0;

var paragraphs =  document.querySelectorAll("p");
paragraphs.forEach(element => {
    element.addEventListener("click", paragraphOnClick);
});

function paragraphOnClick(event){
    let element = event.target;
    let numColor = paragraphsColor.indexOf(element.className) + 1 % paragraphsColor.length;
    console.log(numColor);
    element.className = paragraphsColor[numColor];
}

var titles =  document.querySelectorAll("h1, h2, h3, h4");
titles.forEach(element => {
    element.addEventListener("click", titleOnClick);
});

function titleOnClick(){
    compteurTitle++;
    titles.forEach(element => {
        element.className = titleColor[compteurTitle % titleColor.length];
    });
}