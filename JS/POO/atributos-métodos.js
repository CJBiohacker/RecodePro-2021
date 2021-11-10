// Criação de Classe com atributos e métodos
let Personagem = {
    // Atributos
    nome: 'Dawnfall' ,
    nível: 70,
    classe: 'Guerreiro',
    especialização: 'Armas',
    // Métodos
    setNome: (nome) => {
        Personagem.nome = nome;
        return console.log(`O nome ${nome} foi inserido.`);
    },
    getNome : () => {
        return console.log(Personagem.nome);
    }
}


Personagem.setNome('Eleyas');
Personagem.getNome();

