import React, { useState, useEffect } from 'react';
import { View, Text, TouchableOpacity, FlatList } from 'react-native';                     // Importa os ícones do FontAwesome do pacote do Expo.
import database from '../../config/firebaseconfig'
import styles from './style';

const NovaTarefa = ({ navigation }, props) => {
    const [descricao, setDescricao] = useState(null);

    const addTarefa = () => {
        database.collection('TarefaBD').add({
            descricao: descricao,
            status: false,
        });
        navigation.navigate('Tarefas');
    }

    return (
        <View style={styles.container}>
            <Text style={styles.label}>Descrição</Text>
            <TextInput
                style={styles.textoInput}
                placeholder='Ex.: Estudar Matemática'
                onChangeText={setDescricao}
                value={descricao}
            />
            <TouchableOpacity
                style={styles.botaoSalvar}
                onPress={() => { addTarefa() }}
            >
                <Text
                    style={styles.iconeSalvar}
                >
                    Salvar
                </Text>
            </TouchableOpacity>
        </View>
    )
}