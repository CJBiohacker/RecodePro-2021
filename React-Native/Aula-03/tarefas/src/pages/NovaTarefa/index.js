import React, { useState, useEffect } from 'react';
import { View, Text, TouchableOpacity, FlatList } from 'react-native';
import { FontAwesome } from '@expo/vector-icons';                       // Importa os ícones do FontAwesome do pacote do Expo.
import database from '../../config/firebaseconfig'
import styles from './style';

const NovaTarefa = ({ navigation }) => {
    const [descricao, setDescricao] = useState(null);

    const adcTarefa = () => {
        database.collection('TarefaBD').add({
            descricao: descricao,
            status: false,
        });
        navigation.navigate('Tarefas');
    }

    return (
        <View>
            <Text>Descrição</Text>
            <TextInput
                placeholder='Ex.: Estudar Matemática'
                onChangeText={setDescricao}
                value={descricao}
            />
            <TouchableOpacity
                style={styles.botaoSalvar}
                onPress={adcTarefa()}
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