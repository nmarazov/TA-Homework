function biggest(args) {

    var a = +args[0];
    var b = +args[1];
    var c = +args[2];

    if (a > b && a > c) {
        if (b > c) {
            console.log(a + " " + b + " " + c);
        }
        else{
            console.log(a + " " + c + " " + b);
        }
    }
    else if (b > a && b > c) {
        if (a > c) {
            console.log(b + " " + a + " " + c);
        }
        else{
            console.log(b + " " + c + " " + a);
        }
    }
    else if( c > a && c > b){
       if (b > a) {
            console.log(c + " " + b + " " + a);
        }
        else{
            console.log(c + " " + a + " " + b);
        }
    }
    else{
        console.log(a + " " + a + " " + a);
    }
}
