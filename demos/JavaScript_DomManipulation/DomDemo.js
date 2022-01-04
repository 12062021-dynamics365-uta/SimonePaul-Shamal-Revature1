// Todo List

//create the input element
let inputElem = document.createElement('input');
//Add the element to the body
document.body.appendChild(inputElem);
//create the submit element
let submitTodo = document.createElement('button');
document.body.appendChild(submitTodo);
submitTodo.innerText = 'Submit A New Todo!';


/*********************************************************************
* Class Assignment:
*
*   DOM Group Work:
* - prevent from adding a blank todo.
* - implement a character limit and alert the user that there were too 
*   many chars.
* - make it so that you can simply type enter to submit the new todo.
* - Add an input that allows you to change the title of the todo list. 
************************************************************************/
document.writeln('<br>'); 
//create the input element text box
let listTitleElem = document.createElement('input');
// Add the element text box to the body
document.body.appendChild(listTitleElem);
// Create the submit button element
let submitTitle = document.createElement('button');
//Add the submit button element to the body
document.body.appendChild(submitTitle);
submitTitle.innerText = 'Submit New List Title';

/** ********************************************/

//create the title element for the list
let title = document.createElement('h1');
document.body.appendChild(title);
title.innerText = 'Your Todos!';

let todoList = document.createElement('ul');
document.body.appendChild(todoList);
todoList.innerHTML = `<li> This is the first list item</li>`;
todoList.innerHTML += `<li class="hoverDemo"> This is the second list item</li>`;

//let myUl = document.querySelector('ul');
todoList.classList.add('ulClass');


// add to list using button
submitTodo.addEventListener('click', (event) => {
    let text = inputElem.value;
    if(text.trim().length != 0)
    {
        if(text.trim().length <= 40)
        {
            let myLi = document.createElement('li');
            myLi.innerText = `${text}`;
            todoList.appendChild(myLi);
        }
        else
            alert("Max characters reached: No more than 40 allowed!");
    }
    inputElem.value = '';
    inputElem.focus();
});

// To add item to list using enter 
inputElem.addEventListener('keypress', (event) => {
    let text = inputElem.value;
    if(event.key === 'Enter')
    {
        if(text.trim().length != 0)
        {
            if(text.trim().length <= 40)
            {
                let myLi = document.createElement('li');
                myLi.innerText = `${text}`;
                todoList.appendChild(myLi);
            }
            else
                alert("Max characters reached: No more than 40 allowed!");
        }
        inputElem.value = '';
        inputElem.focus();
    }
});
// to change title pressing enter title
listTitleElem.addEventListener('keypress', (event) => {
    let text = listTitleElem.value;
    if(event.key === 'Enter')
    {
        if(text.trim().length != 0)
        {
            if(text.trim().length <= 40)
            {
                title.innerText = text;
            }
            else
                alert("Max characters reached: No more than 40 allowed!");
        }
        listTitleElem.value = '';
        listTitleElem.focus();
    }
});
// to change title using  button
submitTitle.addEventListener('click', (event) => {
    let text = listTitleElem.value;
    if(text.trim().length != 0)
    {
        if(text.trim().length <= 40)
        {
            title.innerText = text;
         
        }
        else
            alert("Max characters reached: No more than 40 allowed!");
    }
    listTitleElem.value = '';
    listTitleElem.focus();
});


//delete on click
//bubbling
todoList.addEventListener('click', (event) => {
    //console.log(event.target);
    event.stopPropagation();// use this to stop the emission of the event up through hierarchy  
    event.target.remove();
});