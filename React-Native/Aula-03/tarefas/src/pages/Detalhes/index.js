import React, { useState } from "react";
import { View, Text, TextInput, TouchableOpacity } from "react-native";
import database from "../../config/firebaseconfig";
import styles from "../NovaTarefa/style";

const Detalhes = ({ navigation, route }) => {
    const [descricaoEditavel, setDescricaoEditavel] = useState(route.params.description);
    const idTarefa = route.params.id;

    const editTarefa = (descricao, id) => {
        database.collection('TarefaBD').doc(id).update({
            descricao: descricaoEditavel,
        })
        navigation.navigate('Tarefas');
    }

    return (
        <View style={styles.container}>
            <Text style={styles.label}>Descrição</Text>
            <TextInput
                style={styles.textoInput}
                placeholder='Ex.: Estudar Matemática'
                onChangeText={setDescricaoEditavel}
                value={descricaoEditavel} />
            <TouchableOpacity
                style={styles.botaoSalvar}
                onPress={() => { editTarefa(descricaoEditavel, idTarefa) }}
            >
                <Text style={styles.iconeSalvar}>Salvar</Text>
            </TouchableOpacity>
        </View>
    );
};