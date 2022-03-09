import React from 'react';
import { useState } from 'react';
import { Button, Text, TextInput, View } from 'react-native';
import ResultadoIMC from './ResultadoIMC';

const Form = () => {

    const [altura, setAltura] = useState(null);
    const [peso, setPeso] = useState(null);
    const [msg, setMsg] = useState("Preencha os campos altura e peso.");
    const [imc, setImc] = useState(null);
    const [textButton, setTextButton] = useState("Calcular")

    // Função com a lógica de validação dos valores inseridos
    const validaIMCValues = () => {
        if (altura !== null && peso !== null) {
            setMsg("IMC:");
            setPeso(null);
            setAltura(null);
            setTextButton("Novo Calculo");
        } else {
            setImc(null);
            setTextButton("Calcular");
            setMsg("Preencha os valores de altura e peso!");
        }
    }

    // Função que realiza o cálculo do IMC
    const calculaIMC = () => {
        validaIMCValues();
        return setImc((peso / (altura * altura)).toFixed(2));
    }

    return (
        <View>
            <View>
                <Text>Digite sua Altura: </Text>
                <TextInput
                    onChangeText={setAltura}
                    value={altura}
                    placeholder='Ex: 1.69'
                    keyboardType='numeric'
                />
                <Text>Digite seu Peso: </Text>
                <TextInput
                    onChangeText={setPeso}
                    value={peso}
                    placeholder='Ex: 66.5'
                    keyboardType='numeric'
                />
                <Button
                    title={textButton}
                    onPress={() => calculaIMC()} />
            </View>
            <ResultadoIMC
                mensagem={msg}
                valor={imc}
            />
        </View>
    );
}

export default Form;