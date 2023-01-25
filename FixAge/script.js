const button = document.getElementById('fixage');

function fixage() {
  const array = document.getElementById('age').value;
  const numbers = array.split(',');
  let text = "";

  numbers.forEach(element => {
    if (element >= 18 && element <= 60) {
      text += element + ",";
    }
  });

  if (text.length == 0) {
    console.log("NA");
  } else {
    text = text.slice(0, -1).replace(/\s/g, '');
    console.log(text);
  }
  
}

button.addEventListener('click', fixage);