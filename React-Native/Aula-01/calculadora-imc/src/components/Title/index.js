import React from 'react';
import { View, Text } from 'react-native';
import styles from './style';

const Title = () => {
    return (
        // View equivale a div no React Native.
        <View style={styles.}>
            <Text>
                Calculadora IMC
            </Text>
        </View>
    )
}

export default Title; 