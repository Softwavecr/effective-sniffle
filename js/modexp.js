function modulo(divisor, dividend) {
    let remainder = divisor % dividend;
    let trueModulo = trueMod(divisor, dividend);
    let correct = remainder === trueModulo;

    console.log(` ${divisor} MOD ${dividend} = ${correct ? remainder : trueModulo} (R = ${remainder}, T = ${trueModulo})`);
}

const trueMod = (divisor,dividend) => 
    ((divisor % dividend) + dividend) % dividend;


modulo(10, 3);
modulo(-10, 3);
modulo(10, -3);
modulo(-10, -3);
