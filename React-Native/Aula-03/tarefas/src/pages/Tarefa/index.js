import React, { useState, useEffect } from 'react';
import { View, Text, TouchableOpacity, FlatList } from 'react-native';
import { FontAwesome } from '@expo/vector-icons';                       // Importa os ícones do FontAwesome do pacote do Expo.
import database from '../../config/firebaseconfig'
import styles from './style';

const Tarefa = ({ navigation }) => {
    const [tarefa, setTarefa] = useState([]);

    useEffect(() => {
        database.collection("TarefasBD").onSnapshot((query) => {
            const list = [];
            query.forEach((doc) => {
                list.push({ ...doc.data(), id: doc.id });
            });
            setTarefa(list);
        });
    }, []);

    return (
        <View style={styles.container}>
            <FlatList
                showsVerticalScrollIndicator={false}
                data={tarefa}

                renderItem={({ item }) => {
                    return (
                        <View style={styles.styleTarefa}>
                            <TouchableOpacity
                                style={styles.deleteTarefa}
                                onPress={() => { deletarTarefa(item.id) }}
                            >
                                <FontAwesome
                                    nome='star'
                                    size={23}
                                    color='#f92eba'>
                                </FontAwesome>
                            </TouchableOpacity>
                            <Text
                                style={styles.descricaoTarefa}
                                onPress={() => {
                                    navigation.navigate("Detalhes", {
                                        id: item.id,
                                        descricao: item.descricao,
                                    })
                                }}
                            >{item.descricao}</Text>
                        </View>
                    );
                }}
            />
            <TouchableOpacity
                style={styles.botaoNovaTarefa}
                onPress={() => {
                    navigation.navigate('Novas Tarefas');
                }}
            >
                <Text style={styles.iconeBotao}>
                    +
                </Text>
            </TouchableOpacity>
        </View>
    )
}

export default Tarefa; 