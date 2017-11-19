#import math
#import time
import numpy as np

# TODO Write proper test cases.

def sigmoid(x):
    s = 1/(1+np.exp(-x))
    return s

x = np.array([1, 2, 3])
sigmoid(x)
assert str(sigmoid(x)) == str(np.array([ 0.73105858, 0.88079708, 0.95257413]))


def sigmoid_derivative(x):
    s = sigmoid(x)
    ds = s*(1-s)
    return ds

x = np.array([1, 2, 3])
print ("sigmoid_derivative(x) = " + str(sigmoid_derivative(x)))
assert str(sigmoid_derivative(x)) == str(np.array([ 0.19661193, 0.10499359, 0.04517666]))


def image2vector(image):
    assert image.shape == (image.shape[1],image.shape[1],image.shape[2])
    v = image.reshape(image.shape[0]*image.shape[1]*image.shape[2],1)
    return v


# This is a 3 by 3 by 2 array, typically images will be (num_px_x, num_px_y,3) where 3 represents the RGB values
image = np.array([[[ 0.67826139,  0.29380381],
                   [ 0.90714982,  0.52835647],
                   [ 0.4215251 ,  0.45017551]],

                  [[ 0.92814219,  0.96677647],
                   [ 0.85304703,  0.52351845],
                   [ 0.19981397,  0.27417313]],

                  [[ 0.60659855,  0.00533165],
                   [ 0.10820313,  0.49978937],
                   [ 0.34144279,  0.94630077]]])

print ("image2vector(image) = " + str(image2vector(image)))
assert str(image2vector(image)) == str(np.array([[ 0.67826139], [ 0.29380381], [ 0.90714982], [ 0.52835647], [ 0.4215251 ], [ 0.45017551], [ 0.92814219], [ 0.96677647], [ 0.85304703], [ 0.52351845], [ 0.19981397], [ 0.27417313], [ 0.60659855], [ 0.00533165], [ 0.10820313], [ 0.49978937], [ 0.34144279], [ 0.94630077]]))
# TODO Better assertion. Compare vectors not strings.


def normalizeRows(x):
    """
    Implement a function that normalizes each row of the matrix x (to have unit length).

    Argument:
    x -- A numpy matrix of shape (n, m)

    Returns:
    x -- The normalized (by row) numpy matrix. You are allowed to modify x.
    """

    ### START CODE HERE ### (≈ 2 lines of code)
    assert x.shape == (x.shape[0],x.shape[1])
    # Compute x_norm as the norm 2 of x. Use np.linalg.norm(..., ord = 2, axis = ..., keepdims = True)
    x_norm = np.linalg.norm(x, axis=1, keepdims=True)

    # Divide x by its norm.
    x = x/x_norm
    ### END CODE HERE ###

    return x

x = np.array([
    [0, 3, 4],
    [1, 6, 4]])
print("normalizeRows(x) = " + str(normalizeRows(x)))
assert str(normalizeRows(x)) == 	str(np.array([[ 0., 0.6, 0.8 ], [ 0.13736056, 0.82416338, 0.54944226]]))
# TODO Better assertion. Compare vectors not strings.


def softmax(x):
    """Calculates the softmax for each row of the input x.

    Your code should work for a row vector and also for matrices of shape (n, m).

    Argument:
    x -- A numpy matrix of shape (n,m)

    Returns:
    s -- A numpy matrix equal to the softmax of x, of shape (n,m)
    """

    ### START CODE HERE ### (≈ 3 lines of code)
    # Apply exp() element-wise to x. Use np.exp(...).
    x_exp = np.exp(x)

    # Create a vector x_sum that sums each row of x_exp. Use np.sum(..., axis = 1, keepdims = True).
    x_sum = np.sum(x_exp, axis=1, keepdims=True)

    # Compute softmax(x) by dividing x_exp by x_sum. It should automatically use numpy broadcasting.
    s = x_exp/x_sum

    ### END CODE HERE ###

    return s

x = np.array([
    [9, 2, 5, 0, 0],
    [7, 5, 0, 0 ,0]])
print("softmax(x) = " + str(softmax(x)))
expectedVector = np.array([[ 9.80897665e-01, 8.94462891e-04, 1.79657674e-02, 1.21052389e-04, 1.21052389e-04],
                           [ 8.78679856e-01, 1.18916387e-01, 8.01252314e-04, 8.01252314e-04, 8.01252314e-04]])
assert str(softmax(x)) == str(expectedVector)
# TODO Better assertion. Compare vectors not strings.


def L1(yhat, y):
    """
    Arguments:
    yhat -- vector of size m (predicted labels)
    y -- vector of size m (true labels)

    Returns:
    loss -- the value of the L1 loss function defined above
    """

    ### START CODE HERE ### (≈ 1 line of code)
    assert y.size == yhat.size
    loss = np.sum(abs(yhat-y))
    ### END CODE HERE ###

    return loss

yhat = np.array([.9, 0.2, 0.1, .4, .9])
y = np.array([1, 0, 0, 1, 1])
print("L1 = " + str(L1(yhat,y)))
assert L1(yhat,y) == 1.1


def L2(yhat, y):
    """
    Arguments:
    yhat -- vector of size m (predicted labels)
    y -- vector of size m (true labels)

    Returns:
    loss -- the value of the L2 loss function defined above
    """

    ### START CODE HERE ### (≈ 1 line of code)
    #loss = np.sum(abs(np.dot(y-yhat,2)))
    loss = np.sum(abs(np.dot(y-yhat,y-yhat)))
    ### END CODE HERE ###

    return loss

yhat = np.array([.9, 0.2, 0.1, .4, .9])
y = np.array([1, 0, 0, 1, 1])
print("L2 = " + str(L2(yhat,y)))
assert L2(yhat,y) == 0.43
