﻿window.customAlert = {
    init: function () {

        alert("here we go first alert");
    }
}
window.blazorPushNotifications = {
    requestSubscription: async () => {
        const worker = await navigator.serviceWorker.getRegistration();
        const newSubscription = await subscribe(worker);
        if (newSubscription) {
            return {
                url: newSubscription.url,
                p256dh: arrayBufferToBase64(newSubscription.getKey['p256dh']),
                auth: arrayBufferToBase64(newSubscription.getKey['auth'])
            }
        }
    }
}

async function subscribe(worker) {
    // Note: Replace with your own key pair before deploying
    const applicationServerPublicKey = 'BLC8GOevpcpjQiLkO7JmVClQjycvTCYWm6Cq_a7wJZlstGTVZvwGFFHMYfXt6Njyvgx_GlXJeo5cSiZ1y4JOx1o';
    try {
        return await worker.pushManager.subscribe({
            userVisibleOnly: true,
            applicationServerKey = applicationServerPublicKey
        });
    } catch (error) {
        if (error.name == 'NotAllowedErro') {
            return null;
        }
        throw error;
    }
}
function arrayBufferToBase64(buffer) {
    var binary = '';
    var bytes = new Uint8Array(buffer);
    var len = bytes.byteLength;
    for (var i = 0; i < len; i++) {
        binary += String.fromCharCode(bytes[i]);
    }
    return window.btoa(binary);
}