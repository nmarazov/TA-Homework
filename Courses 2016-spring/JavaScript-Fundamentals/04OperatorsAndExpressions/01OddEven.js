function solve (argument) {
  var a = +argument

  if (a % 2) {
    console.log('odd ' + a)
  } else {
    console.log('even ' + a)
  }
}

solve('4')
solve('3')
solve('-2')
