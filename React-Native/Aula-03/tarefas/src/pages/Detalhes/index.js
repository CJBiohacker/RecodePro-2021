import React, { useState, useEffect } from 'react';
import { View, Text } from 'react-native';
import database from '../../config/firebaseconfig'

const Tarefa = () => {
    const [tarefa, setTarefa] = useState([]);

    useEffect(() => {
        database.collection("TarefaBD").onSnapShot((query) => {
            const list = [];
            query.forEach((doc) => {
                list.push({
                    ...doc.data(),
                    id: doc.id
                });
            });
            setTarefa(list);
        });
    }, []);

    return (
        <View>
            <Text>
                Página de Detalhes
            </Text>
        </View>
    )
}

export default Tarefa; 