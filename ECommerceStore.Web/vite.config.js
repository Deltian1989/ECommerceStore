import { defineConfig } from "vite";

export default defineConfig({
    build: {
        outDir: "wwwroot/build",
        rollupOptions: {
            input: {
                main: "./src/main.js"
            },
            output: {
                entryFileNames: "bundle.js",
                assetFileNames: "styles.css"
            }
        }
    }
});