function modulo(dividend, divisor) {
    let remainder = dividend % divisor;
    let trueModulo = trueMod(dividend, divisor);
    let correct = remainder === trueModulo;

    console.log(` ${dividend} MOD ${divisor} = ${correct ? remainder : trueModulo} (R = ${remainder}, T = ${trueModulo})`);
}

const trueMod = (dividend, divisor) => 
    ((dividend % divisor) + divisor) % divisor;

modulo(10, 3);
modulo(-10, 3);
modulo(10, -3);
modulo(-10, -3);
