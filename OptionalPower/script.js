const button = document.getElementById("question");

function optionalPow() {
  const a = document.getElementById("a").value;
  const b = document.getElementById("b").value;
  let power;

  if (confirm('Question')) {
    power = a ** b;
  } else {
    power = b ** a;
  }	

  console.log(power);

  return power;
}

button.addEventListener('click', optionalPow);

