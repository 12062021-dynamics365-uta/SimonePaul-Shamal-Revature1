// creates the button
let fetch1Joke = document.createElement('button');
// adds the button to the body of webpage
document.body.appendChild(fetchJoke);
// changes text on button 
fetch1Joke.innerText = 'Get 1 Joke from Chuck Norris!';

let xhr = new  XMLHttpRequest();



// if arrow func body is more than 1 line use {} to bound body
//fetch1Joke.addEventListener

fetch1Joke.onclick = () => 
{
console.log(`This is the .onclick  and value is onclick() is ${fetch1Joke.innerText}`);

xhr.onreadystatechange = () => {

  console.log(`The readystate is ${xhr.readyState}`);

if (xhr.readyState === 4)
{
    console.log(`the response is ${xhr.responseText}`);
}

let myDiv = document.createElement(`div`);
let myPara = document.createElement('p');
myDiv.appendChild(myPara)
document.body.appendChild(myDiv);
myPara.innerText = JSON.parse(xhr.responseText);
console.log(JSON.parse(xhr.responseText));
}
xhr.open('get',`http://api.icndb.com/jokes/random`);
xhr.send();

}

let fiveJokeButton = document.createElement(`button`);
document.body.appendChild(fiveJokeButton);
fiveJokeButton.innerText = Click to get 

fiveJokeButton.onclick= () => { 
 fetch('http://api.icndb.com/jokes/random')
 .then 
}